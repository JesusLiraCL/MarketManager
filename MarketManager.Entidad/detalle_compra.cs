using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketManager.Entidad
{
    public class detalle_compra
    {
        public compra ocompra { get; set; }
        public producto oproducto { get; set; }
        public int cantidad { get; set; }
        public decimal precio_total { get; set; }
    }
}
