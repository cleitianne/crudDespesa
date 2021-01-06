using Mobills.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mobills.Services.Interfaces
{
    public interface IDespesaService
    {
        Despesa GetById(int Id);
        IQueryable<Despesa> GetAll();
        Despesa Create(Despesa entity);
        void Delete(int id);
        void Update(Despesa entity, int id);
        decimal Somatorio();

    }
}
