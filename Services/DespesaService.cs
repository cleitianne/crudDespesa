using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using crudDespesa.Repositories.Interfaces;
using Mobills.Models;
using Mobills.Repositories;
using Mobills.Services.Interfaces;

namespace Mobills.Services
{
    public class DespesaService : IDespesaService
    {
        private readonly IDespesaRepository _repository;
        public DespesaService(IDespesaRepository repository)
        {
            this._repository = repository;
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

        public decimal Somatorio()
        {
            var despesas = this._repository.GetAll();
            decimal soma = 0;
            foreach(Despesa despesa in despesas)
            {
                if(despesa.Pago)
                {
                    soma = soma + despesa.Valor;
                }
            }
            return soma;
        }
    }
}