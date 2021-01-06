using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mobills.Models;
using Mobills.Services;

namespace Mobills.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultasController : ControllerBase
    {
        public readonly ConsultaService _service;
        public ConsultasController(Context context)
        {
            this._service = new ConsultaService(context);
        }
        [HttpGet("saldo")]
        public IActionResult Soma()
        {
            return Ok(this._service.ConsultarSaldo());
        }
    }
}