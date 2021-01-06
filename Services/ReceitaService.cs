using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mobills.Models;
using Mobills.Repositories;

namespace Mobills.Services
{
    public class ReceitaService
    {
        private readonly ReceitasRepository _repository;
        public ReceitaService(Context context)
        {
            this._repository = new ReceitasRepository(context);
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