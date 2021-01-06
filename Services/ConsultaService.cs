using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mobills.Models;

namespace Mobills.Services
{
    public class ConsultaService
    {
        private readonly DespesaService _despesaService;
        private readonly ReceitaService _receitaService;
        public ConsultaService(Context context)
        {
            this._despesaService = new DespesaService(context);
            this._receitaService = new ReceitaService(context);
        }

        public decimal ConsultarSaldo()
        {
            return _receitaService.Somatorio() - _despesaService.Somatorio();

        }

    }
}