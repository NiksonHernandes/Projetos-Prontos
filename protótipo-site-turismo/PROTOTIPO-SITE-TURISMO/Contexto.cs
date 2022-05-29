using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PROTOTIPO_SITE_TURISMO.Entidades;

namespace PROTOTIPO_SITE_TURISMO
{
    public class Contexto : DbContext //representa o nosso banco de dados
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }
        public DbSet<Usuarios> USUARIOS { get; set; }
        public DbSet<Login> LOGIN { get; set; }
        public DbSet<Passagens> PASSAGENS { get; set; }
        public DbSet<PassagemCompleta> PASSAGEMCOMPLETA { get; set; }
       
    }
}
