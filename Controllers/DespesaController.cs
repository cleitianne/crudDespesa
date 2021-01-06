using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mobills.Models;
using Mobills.Services;
using Mobills.Services.Interfaces;

namespace Mobills.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DespesasController : ControllerBase
    {
        public IDespesaService _service;
        public DespesasController(IDespesaService service)
        {
            _service = service;
        }


        [HttpGet]
        public IQueryable<Despesa> GetAll()
        {
            return _service.GetAll();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var entity = _service.GetById(id);
            if (entity == null)
            {
                return NotFound();
            }
            return Ok(entity);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Despesa entity)
        {

            if (entity == null)
            {
                return BadRequest("Não pode ser null");
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(_service.Create(entity));
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Despesa entity)
        {
            if (entity == null)
            {
                return BadRequest();
            }
            _service.Update(entity, id);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var entity = _service.GetById(id);
            if (entity == null)
            {
                return NotFound();
            }
            _service.Delete(id);
            return Ok();
        }
        [HttpGet("soma")]
        public IActionResult Soma()
        {
            return Ok(this._service.Somatorio());
        }
    }
}