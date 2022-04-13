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
        public string sucursal { get; set; }
        public string FechaHoy { get; set; }
        public string estado { get; set; }
        public string responsable { get; set; }
    }
}
