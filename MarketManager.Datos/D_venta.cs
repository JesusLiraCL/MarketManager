using MarketManager.Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketManager.Datos
{
    public class D_venta
    {
        public List<venta> Listar()
        {
            List<venta> lista = new List<venta>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {

                try
                {
                    string query = "SELECT * FROM venta";
                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new venta()
                            {
                                codigo_factura = Convert.ToInt32(dr["codigo_factura"]),
                                cedula_usuario = Convert.ToInt32(dr["cedula_usuario"]),
                                cedula_persona = Convert.ToInt32(dr["cedula_persona"]),
                                fecha = dr["fecha"].ToString(),
                                monto = Convert.ToDecimal(dr["monto"])


                            }) ;


                        }

                    }


                }
                catch (Exception)
                {
                    lista = new List<venta>();
                }

            }
            return lista;

        }
    }
}
