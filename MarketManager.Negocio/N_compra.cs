using MarketManager.Datos;
using MarketManager.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketManager.Negocio
{
    public class N_compra
    {
        private D_compra objcd_compra = new D_compra();

        public List<compra> Listar()
        {
            return objcd_compra.Listar();

        }
    }
}
