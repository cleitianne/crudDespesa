using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mobills.Models;
using Mobills.Repositories.Interfaces;

namespace Mobills.Repositories
{
    public class ReceitasRepository : IReceitaRepository
    {
        private readonly Context _context;

        public ReceitasRepository(Context context)
        {
            this._context = context;
        }

        public Receita GetById(int Id)
        {
            return this._context.Receita.Find(Id);
        }
        public IQueryable<Receita> GetAll()
        {
            return _context.Receita.AsQueryable();
        }
        public Receita Create(Receita entity)
        {
            _context.Receita.Add(entity);
            _context.SaveChanges();
            return entity;
        }
        public void Delete(int id)
        {
            var entity = GetById(id);
            _context.Receita.Remove(entity);
            _context.SaveChanges();
        }

        public void Update(Receita entity, int id)
        {
            var exist = _context.Receita.Find(id);
            _context.Entry(exist).CurrentValues.SetValues(entity);
            _context.SaveChanges();
        }
    }
}