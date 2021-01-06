using Mobills.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mobills.Repositories.Interfaces
{
    public interface IReceitaRepository
    {
        Receita GetById(int Id);

        IQueryable<Receita> GetAll();
        Receita Create(Receita entity);
        void Delete(int id);
        void Update(Receita entity, int id);
        
    }
}
