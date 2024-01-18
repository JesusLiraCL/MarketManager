using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MarketManager.Datos;
using MarketManager.Entidad;

namespace MarketManager.Negocio
{
    public class N_Personanombre
    {
        private D_Personanombre objcd_personanombre = new D_Personanombre();

        public List<persona> Listar()
        {
            return objcd_personanombre.Listar();

        }

        public string Registrar(persona obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.cedula_persona.Equals(""))
            {
                Mensaje += "Es necesario la cedula de la persona";
            }
            else if (obj.nombre_persona == string.Empty)
            {
                Mensaje += "Es necesario la nombre de la persona";
            }
            else if (obj.apellido_persona == string.Empty)
            {
                Mensaje += "Es necesario la apellido de la persona";
            }
            else if (obj.direccion == string.Empty)
            {
                Mensaje += "Es necesario la direccion de la persona";
            }
            else if (obj.telefono == string.Empty)
            {
                Mensaje += "Es necesario la telefono de la persona";
            }
            else if (obj.correo == string.Empty)
            {
                Mensaje += "Es necesario la correo de la persona";
            }
            if (Mensaje != string.Empty)
            {

                return "0";
            }
            else
            { 
                return objcd_personanombre.Registrar(obj, out Mensaje);
            }



        }


        public bool Editar(persona obj, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (obj.cedula_persona.Equals(""))
            {
                Mensaje += "Es necesario la cedula de la persona";
            }
            if (obj.nombre_persona == string.Empty)
            {
                Mensaje += "Es necesario la nombre de la persona";
            }
            if (obj.apellido_persona == string.Empty)
            {
                Mensaje += "Es necesario la apellido de la persona";
            }
            if (obj.direccion == string.Empty)
            {
                Mensaje += "Es necesario la direccion de la persona";
            }
            if (obj.telefono == string.Empty)
            {
                Mensaje += "Es necesario la telefono de la persona";
            }
            if (obj.correo == string.Empty)
            {
                Mensaje += "Es necesario la correo de la persona";
            }
            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcd_personanombre.Editar(obj, out Mensaje);
            }
            

        }
    }
}
