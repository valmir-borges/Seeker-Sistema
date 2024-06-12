using Microsoft.EntityFrameworkCore;

namespace Sistema_Desaparecidos.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) 
        { }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Pessoa> Pessoa { get; set; }
        public DbSet<Observacoes> Observacoes { get; set; }
    }
}
