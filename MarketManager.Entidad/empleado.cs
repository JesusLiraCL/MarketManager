using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketManager.Entidad
{
    public class empleado
    {
        public string cedula_empleado { get; set; }
        public string nombre_persona { get; set; }
        public string apellido_persona { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }
        public string nombre_cargo { get; set; }
    }
}