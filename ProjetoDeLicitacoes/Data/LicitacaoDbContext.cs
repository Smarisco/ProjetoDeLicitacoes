using Microsoft.EntityFrameworkCore;
using ProjetoDeLicitacoes.Models;

namespace ProjetoDeLicitacoes.Data
{
    public class LicitacaoDbContext : DbContext
    {
        public LicitacaoDbContext(DbContextOptions<LicitacaoDbContext> options)
            : base(options)
        {
        }
        public LicitacaoDbContext()
        {
                
        }

        public DbSet<Licitacao> Licitacao { get; set; }
    
    }
}
