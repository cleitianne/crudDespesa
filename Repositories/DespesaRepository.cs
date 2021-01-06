using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mobills.Models;

namespace Mobills.Repositories
{
    public class DespesaRepository
    {
        private readonly Context _context;

        public DespesaRepository(Context context)
        {
            this._context = context;
        }

        public Despesa GetById (int Id)
        {
            return this._context.Despesa.Find(Id);
        }
        public IQueryable<Despesa> GetAll()
        {
            return _context.Despesa.AsQueryable();
        }
        public Despesa Create(Despesa entity)
        {
            _context.Despesa.Add(entity);
            _context.SaveChanges();
            return entity;
        }
        public void Delete(int id)
        {
            var entity = GetById(id);
            _context.Despesa.Remove(entity);
            _context.SaveChanges();
        }

        public void Update(Despesa entity, int id)
        {
            var exist = _context.Despesa.Find(id);
            _context.Entry(exist).CurrentValues.SetValues(entity);
            _context.SaveChanges();
        }
    }
}