using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROTOTIPO_SITE_TURISMO.Entidades
{
    public class Passagens
    {
        public int Id { get; set; }
        public string Cidade { get; set; }
        public decimal Preco { get; set; }
        public string Detalhes { get; set; }
    }
}
