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
    public class D_compra
    {
        public List<compra> Listar()
        {
            List<compra> lista = new List<compra>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {

                try
                {
                    string query = "SELECT * FROM compra";
                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new compra()
                            {
                                id_compra = Convert.ToInt32(dr["id_compra"]),
                                codigo_proveedor = Convert.ToInt32(dr["codigo_proveedor"]),
                                cedula_usuario = Convert.ToInt32(dr["cedula_usuario"]),
                                fecha = dr["fecha"].ToString(),
                                monto = Convert.ToDecimal(dr["monto"])


                            });


                        }

                    }


                }
                catch (Exception)
                {
                    lista = new List<compra>();
                }

            }
            return lista;

        }
    }
}
