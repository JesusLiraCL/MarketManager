using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarketManager.Datos;
using MarketManager.Entidad;

namespace MarketManager.Negocio
{
    public class N_usuario
    {
        private D_usuarios objcd_usuario = new D_usuarios();

        public List<usuario> Listar()
        {
            return objcd_usuario.Listar();

        }
    }
}
