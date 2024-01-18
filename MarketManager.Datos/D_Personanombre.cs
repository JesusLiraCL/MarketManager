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
    public class D_Personanombre
    {
        public List<persona> Listar()
        {
            //Mostrar Personas
            List<persona> lista = new List<persona>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {

                try
                {
                    string query = "SELECT persona.cedula_persona, persona.nombre_persona, persona.apellido_persona, persona.direccion,persona.telefono,persona.correo FROM persona";
                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new persona()
                            {
                                cedula_persona = dr["cedula_persona"].ToString(),
                                nombre_persona = dr["nombre_persona"].ToString(),
                                apellido_persona = dr["apellido_persona"].ToString(),
                                direccion = dr["direccion"].ToString(),
                                telefono = dr["telefono"].ToString(),
                                correo = dr["correo"].ToString()





                            });


                        }

                    }






                }
                catch (Exception)
                {
                    lista = new List<persona>();
                }

            }
            return lista;

        }
        //Guardar Personas

        public string Registrar(persona obj, out string Mensaje) 
        {
            Mensaje = string.Empty;


            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena)) 
                {
                    SqlCommand cmd = new SqlCommand("RegistrarUsuario", oconexion);
                    cmd.Parameters.AddWithValue("cedula_persona", obj.cedula_persona);
                    cmd.Parameters.AddWithValue("nombre_persona", obj.nombre_persona);
                    cmd.Parameters.AddWithValue("apellido_persona", obj.apellido_persona);
                    cmd.Parameters.AddWithValue("direccion", obj.direccion);
                    cmd.Parameters.AddWithValue("telefono", obj.telefono);
                    cmd.Parameters.AddWithValue("correo", obj.correo);
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar,500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();


                }

            }
            catch (Exception ex) 
            {
                Mensaje = ex.Message;

            }
            return Mensaje;
            
        
        }



        public bool Editar(persona obj, out string Mensaje)
        {
            bool resultado = false;
            Mensaje = string.Empty;


            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("EditarUsuarios", oconexion);
                    cmd.Parameters.AddWithValue("cedula_persona", obj.cedula_persona);
                    cmd.Parameters.AddWithValue("nombre_persona", obj.nombre_persona);
                    cmd.Parameters.AddWithValue("apellido_persona", obj.apellido_persona);
                    cmd.Parameters.AddWithValue("direccion_persona", obj.direccion);
                    cmd.Parameters.AddWithValue("telefono_persona", obj.telefono);
                    cmd.Parameters.AddWithValue("correo", obj.correo);
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar,500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    resultado = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();


                }

            }
            catch (Exception ex)
            {
                resultado = false;
                Mensaje = ex.Message;

            }
            return resultado;

        }










    }
}
