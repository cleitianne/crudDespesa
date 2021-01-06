using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mobills.Models;
using Mobills.Repositories;
using Mobills.Repositories.Interfaces;
using Mobills.Services.Interfaces;

namespace Mobills.Services
{
    public class ReceitaService : IReceitaService
    {
        private readonly IReceitaRepository _repository;
        public ReceitaService(IReceitaRepository repository)
        {
            this._repository = repository;
        }
        public Receita GetById(int Id)
        {
            return this._repository.GetById(Id);
        }
        public IQueryable<Receita> GetAll()
        {
            return this._repository.GetAll();
        }
        public Receita Create(Receita entity)
        {
            return this._repository.Create(entity);
        }
        public void Delete(int id)
        {
            this._repository.Delete(id);
        }

        public void Update(Receita entity, int id)
        {
            this._repository.Update(entity, id);
        }

        public decimal Somatorio()
        {
            var receitas = this._repository.GetAll();
            decimal soma = 0;
            foreach (Receita receita in receitas)
            {
                if (receita.Recebido)
                {
                    soma = soma + receita.Valor;
                }
            }
            return soma;
        }
    }
}