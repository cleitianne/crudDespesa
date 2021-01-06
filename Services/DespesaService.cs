using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mobills.Models;
using Mobills.Repositories;

namespace Mobills.Services
{
    public class DespesaService
    {
        private readonly DespesaRepository _repository;
        public DespesaService(Context context)
        {
            this._repository = new DespesaRepository(context);
        }
        public Despesa GetById(int Id)
        {
            return this._repository.GetById(Id);
        }
        public IQueryable<Despesa> GetAll()
        {
            return this._repository.GetAll();
        }
        public Despesa Create(Despesa entity)
        {
            return this._repository.Create(entity);
        }
        public void Delete(int id)
        {
            this._repository.Delete(id);
        }

        public void Update(Despesa entity, int id)
        {
            this._repository.Update(entity, id);
        }

        public double Somatorio()
        {
            var despesas = this._repository.GetAll();
            double soma = 0;
            foreach(Despesa despesa in despesas)
            {
                if(despesa.Pago)
                {
                    soma += despesa.Valor;
                }
            }
            return soma;
        }
    }
}