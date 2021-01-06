using System.Linq;
using Mobillis.Models;

namespace crudDespesa.Repositories
{
    public class DespesasRepository
    {
        private readonly Context _context;

        public DespesasRepository(Context context){
            this._context = context;
        }
        public Despesa GetById(int Id){
            return this._context.Despesas.Find(Id);
        }
        public IQueryable<Despesa>GetAll(){
            return _context.Despesas.AsQueryable();
        }
        public void Deletar(int id){
            var entity = GetById(id);
            _context.Despesas.Remove(entity);
            _context.SaveChanges();
        }
        public Despesa Criar(Despesa entity){
            _context.Despesas.Add(entity);
            _context.SaveChanges();
            return entity;
        }
        public void Atualizar(Despesa entity, int id){
            var existe = _context.Despesas.Find(id);
            _context.Entry(existe).CurrentValues.SetValues(entity);
            _context.SaveChanges();
        }
    }
}