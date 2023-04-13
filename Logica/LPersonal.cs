using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Empleados.Logica
{
    public class LPersonal
    {
        public int IdPersonal { get; set; }
        public string Nombres { get; set; }
        public string Cedula { get; set; }
        public string Direccion { get; set; }
        public int IdCargo { get; set; }
        public double SueldoPorHora { get; set; }
        public string Estado { get; set; }
        public string Codigo { get; set; }
    }
}
