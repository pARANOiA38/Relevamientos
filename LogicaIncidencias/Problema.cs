using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaIncidencias
{
    public class Problema
    {
        public int cod { get; set; }
        public string dependencia { get; set; }
        public string observacion { get; set; }
        public string sucursarl { get; set; }
        public DateTime FechaHoy { get; set; }
        public bool estado { get; set; }
    }
}
