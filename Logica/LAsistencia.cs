using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Empleados.Logica
{
    public class LAsistencia
    {
        public int IdAsistencia { get; set; }
        public int IdPersonal { get; set; }
        public DateTime FechaEntrada { get; set; }
        public DateTime FechaSalida { get; set; }
        public string Estado { get; set; }
        public double Horas { get; set; }        
        public double Adelanto { get; set; }
    }
}
