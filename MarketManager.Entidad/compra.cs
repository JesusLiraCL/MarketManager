using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketManager.Entidad
{
    public class compra
    {
        public int id_compra { get; set; }
        public int codigo_proveedor { get; set; }
        public int cedula_usuario { get; set; }
        public string fecha { get; set; }
        public decimal monto { get; set; }
    }
}
