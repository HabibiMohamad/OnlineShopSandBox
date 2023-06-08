using Microsoft.EntityFrameworkCore;

namespace Sass.Models
{
    public class Appdbcontext : DbContext

    {
        public DbSet<Product> Products { get; set; }
        public Appdbcontext(DbContextOptions<Appdbcontext> options)
       : base(options)
        { 

        }

    }
}
