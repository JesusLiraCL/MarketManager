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
    public class D_empleado
    {
        public List<empleado> Listar()
        {
            //Mostrar Personas
            List<empleado> lista = new List<empleado>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "Select cedula_persona,nombre_persona,direccion,telefono,correo,nombre_cargo FROM persona AS P JOIN empleado AS E ON P.cedula_persona = E.cedula_empleado JOIN cargo AS C ON C.codigo_cargo = E.codigo_cargo";
                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new empleado()
                            {
                                cedula_empleado = dr["cedula_empleado"].ToString(),
                                nombre_persona = dr["nombre_persona"].ToString(),
                                apellido_persona = dr["apellido_persona"].ToString(),
                                direccion = dr["direccion"].ToString(),
                                telefono = dr["telefono"].ToString(),
                                correo = dr["correo"].ToString(),
                                nombre_cargo = dr["nombre_cargo"].ToString()

                            });
                        }
                    }
                }

                catch (Exception)
                {
                    lista = new List<empleado>();
                }

            }

            return lista;
        }
    }
}