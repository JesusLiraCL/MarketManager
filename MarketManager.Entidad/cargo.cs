using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketManager.Entidad
{
    public class cargo
    {
        public int codigo_cargo { get; set; }
        public string nombre_cargo { get; set; }
        public string descripcion { get; set; }
        public decimal sueldo { get; set; }
    }
}
