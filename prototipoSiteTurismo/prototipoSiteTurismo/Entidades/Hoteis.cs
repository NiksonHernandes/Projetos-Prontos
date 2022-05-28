using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prototipoSiteTurismo.Entidades
{
    public class Hoteis
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cidade { get; set; }
        public string DataSaida { get; set; }
        public string DataChegada { get; set; }
        public string Preco { get; set; }
        public string Detalhes { get; set; }
    }
}
