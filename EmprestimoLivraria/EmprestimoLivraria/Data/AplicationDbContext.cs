using EmprestimoLivraria.Models;
using Microsoft.EntityFrameworkCore;

namespace EmprestimoLivraria.Data
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
        {

        }

        public DbSet<EmprestimosModel> Emprestimos { get; set; } //Criando a tabela no Context / Banco
            
    }
}
