using Microsoft.EntityFrameworkCore;
using prototipoSiteTurismo.Entidades;


namespace prototipoSiteTurismo
{
    public class Contexto : DbContext //Confugração do banco de dados de cada controler
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }
        public DbSet<Passagem> PASSAGEM { get; set;  }
       
    }
}
