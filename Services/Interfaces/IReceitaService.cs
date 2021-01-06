using Mobills.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mobills.Services.Interfaces
{
    public interface IReceitaService
    {
        Receita GetById(int Id);
        IQueryable<Receita> GetAll();
        Receita Create(Receita entity);
        void Delete(int id);
        void Update(Receita entity, int id);
        decimal Somatorio();
        
    }
}
