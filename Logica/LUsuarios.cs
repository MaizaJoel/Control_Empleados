﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Empleados.Logica
{
    public class LUsuarios
    {
        public int IdUsuario { get; set; }
        public string NombreApellido { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public byte[] Icono { get; set; }
        public string Estado { get; set; }
    }
}
