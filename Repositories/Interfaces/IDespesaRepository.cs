using Mobills.Models;
using System.Linq;

namespace crudDespesa.Repositories.Interfaces
{
    public interface IDespesaRepository
    {
        Despesa GetById (int Id);
        
        IQueryable<Despesa> GetAll();
        Despesa Create(Despesa entity);
        void Delete(int id);

        void Update(Despesa entity, int id);
    }
}