using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using MarketManager.Entidad;
using MarketManager.Datos;

namespace MarketManager.Datos
{
    public class D_usuarios
    {
        public List<usuario> Listar()
        {
            List<usuario> lista = new List<usuario>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {

                try
                {
                    /*string query = "SELECT usuario.cedula, usuario.nombre_usuario, usuario.contraseña, usuario.fecha_creacion, codigo_rol FROM usuario";*/
                    string query = "SELECT usuario.*, rol.nombre_rol FROM usuario JOIN rol ON usuario.codigo_rol = rol.codigo_rol; ";
                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new usuario()
                            {
                                cedula = dr["cedula"].ToString(),
                                nombre_usuario = dr["nombre_usuario"].ToString(),
                                contraseña = dr["contraseña"].ToString(),
                                fecha_creacion = dr["fecha_creacion"].ToString(),
                                codigo_rol = dr["codigo_rol"].ToString(),
                                nombre_rol = dr["nombre_rol"].ToString()
                                
                                





                            }) ;


                        }

                    }






                }
                catch (Exception)
                {
                    lista = new List<usuario>();
                }

            }
            return lista;

        }
    }
}
