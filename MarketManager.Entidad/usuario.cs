using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketManager.Entidad
{
    public class usuario
    {
        public object codigo_rol;
        public string nombre_rol;
        public string descripcion;

        public string cedula { get; set; }
        public string nombre_usuario { get; set; }
        public string contraseña { get; set; }
        public string fecha_creacion { get; set; }
        public rol orol { get; set; }
    }
}
