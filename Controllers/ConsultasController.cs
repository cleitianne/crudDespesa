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
    public class ConsultasController : ControllerBase
    {
        public readonly IConsultaService _service;
        public ConsultasController(IConsultaService service)
        {
            this._service = service;
        }
        [HttpGet("saldo")]
        public IActionResult Soma()
        {
            return Ok(this._service.ConsultarSaldo());
        }
    }
}