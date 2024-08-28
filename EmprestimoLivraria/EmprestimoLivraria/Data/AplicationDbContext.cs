using Microsoft.EntityFrameworkCore;

namespace EmprestimoLivraria.Data
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options ) : base(options)
        {
            
        }


    }
}
