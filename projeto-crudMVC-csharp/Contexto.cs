using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using projeto_crudMVC_csharp.Entidades; //diz pro  banco que vou usar a pasta entidades do meu projeto

namespace projeto_crudMVC_csharp
{
    //essa classe contexto representa o nosso banco de dados
    public class Contexto:DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

        public DbSet<Usuarios> USUARIOS { get; set; }
    }
}
