using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mobills.Models;
using Mobills.Services.Interfaces;

namespace Mobills.Services
{
    public class ConsultaService : IConsultaService
    {
        private readonly IDespesaService _despesaService;
        private readonly IReceitaService _receitaService;
        public ConsultaService(IDespesaService despesaService, IReceitaService receitaService)
        {
            this._despesaService = despesaService;
            this._receitaService = receitaService;
        }

        public decimal ConsultarSaldo()
        {
            return _receitaService.Somatorio() - _despesaService.Somatorio();

        }

    }
}