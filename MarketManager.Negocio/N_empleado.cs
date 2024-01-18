using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MarketManager.Datos;
using MarketManager.Entidad;

namespace MarketManager.Negocio
{
    public class N_empleado
    {
        private D_empleado objcd_empleado = new D_empleado();

        public List<empleado> Listar()
        {
            return objcd_empleado.Listar();

        }
    }
}