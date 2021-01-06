using Microsoft.EntityFrameworkCore;
using Mobillis.Models;

namespace crudDespesa
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
         {}

         public DbSet<Despesa> Despesas { get; set; }
    }
}