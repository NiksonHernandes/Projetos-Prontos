using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_crudMVC_csharp.Entidades
{
    //classes da entidade para que fique no banco de dados - tabela de cadastro de usuarios 
    public class Usuarios
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
    }
}
