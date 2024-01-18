using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketManager.Entidad
{
    public class producto
    {
        public int codigo_producto { get; set; }
        public string nombre_producto { get; set; }
        public string marca { get; set; }
        public string descripcion { get; set; }
        public decimal precio_compra { get; set; }
        public decimal precio_venta { get; set; }
        public categoria ocategoria { get; set; }
        public int inventario { get; set; }
        public int anaquel { get; set; }

    }
}
