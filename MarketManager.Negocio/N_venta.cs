using MarketManager.Datos;
using MarketManager.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketManager.Negocio
{
    public class N_venta
    {
        private D_venta objcd_venta = new D_venta();

        public List<venta> Listar()
        {
            return objcd_venta.Listar();

        }
    }
}
