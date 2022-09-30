using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prototipoSiteTurismo.Entidades
{
    public class Passagem
    {
        public int Id { get; set; }
        public string CidadeSaida { get; set; }
        public string CidadeChegada { get; set; }
        public string DataSaida { get; set; }
        public string DataChegada { get; set; }
        public decimal Preco { get; set; }
        public string Detalhes { get; set; }
    }
}
