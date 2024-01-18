using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketManager.Entidad
{
    public class venta
    {
        public int codigo_factura { get; set; }
        public int cedula_usuario { get; set; }
        public int cedula_persona { get; set; }
        public string fecha { get; set; }
        public decimal monto { get; set; }
    }
}
