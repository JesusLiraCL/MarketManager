using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketManager.Entidad
{
    public class proveedor
    {
        public int codigo_proveedor { get; set; }
        public string nombre_proveedor { get; set; }
        public string ubicacion { get; set; }
        public int cedula_contacto { get; set; }
        public string nombre_contacto { get; set; }
        public string apellido_contacto { get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }
    }
}
