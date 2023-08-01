using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Entities.Concrete;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.DataAccess.Concrete.EntitiyFrameWork
{
    public class SystemContext : DbContext

    {

        public DbSet<Product> Products { get; set; }    // It need be public to accessible
        public DbSet<Category> Categories { get; set; } 

        public SystemContext()
        {

        }

        public SystemContext(DbContextOptions<SystemContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server = (localdb)\\MSSQLLocalDB; initial catalog = Northwind;" +
                "integrated security = true");
            base.OnConfiguring(optionsBuilder);
        }

    }



}
