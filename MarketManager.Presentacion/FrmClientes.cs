using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MarketManager.Negocio;
using MarketManager.Entidad;

namespace MarketManager.Presentacion
{
    public partial class FrmClientes : Form
    {


        private static persona PersonaValidada;
        public FrmClientes()
        {

            InitializeComponent();
        }


        private void FrmClientes_Load(object sender, EventArgs e)
        {
            textCedula.Focus();
            List<persona> lista_persona = new N_Personanombre().Listar();

            foreach (persona item in lista_persona)
            {
                tabla_Clientes.Rows.Add(new object[] {
                    item.cedula_persona,
                    item.nombre_persona,
                    item.apellido_persona,
                    item.direccion,
                    item.telefono,
                    item.correo});
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

            string Mensaje = string.Empty;
            persona objpersona = new persona()
            {
                cedula_persona = textCedula.Text,
                nombre_persona = txtNombre.Text,
                apellido_persona = txtApellido.Text,
                telefono = txtTelefono.Text,
                direccion = txtDireccion.Text,
                correo = txtCorreo.Text,

            };
            PersonaValidada = objpersona;


            string registrarpersona = new N_Personanombre().Registrar(objpersona, out Mensaje);
            List<persona> test = new N_Personanombre().Listar();
            persona lista_persona = new N_Personanombre().Listar().Where(u => u.cedula_persona == PersonaValidada.cedula_persona).FirstOrDefault();

            
            if (lista_persona == null)
            {
                MessageBox.Show(Mensaje);
            }
            else if (lista_persona.cedula_persona == PersonaValidada.cedula_persona && lista_persona != null)
            {
                MessageBox.Show(Mensaje);
      
            }
            else
            {
                tabla_Clientes.Rows.Add(new object[] { textCedula.Text, txtNombre.Text, txtApellido.Text, txtDireccion.Text, txtTelefono.Text, txtCorreo.Text });
                tabla_Clientes.Refresh();
            }    
            
            Limpiar();
            textCedula.Focus();
  
            
        }
        private void Limpiar()
        { 
            textCedula.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtCorreo.Text = string.Empty;

        }

        private void tabla_Clientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textCedula.Text = tabla_Clientes.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = tabla_Clientes.CurrentRow.Cells[1].Value.ToString();
            txtApellido.Text = tabla_Clientes.CurrentRow.Cells[2].Value.ToString();
            txtDireccion.Text = tabla_Clientes.CurrentRow.Cells[3].Value.ToString();
            txtTelefono.Text = tabla_Clientes.CurrentRow.Cells[4].Value.ToString();
            txtCorreo.Text = tabla_Clientes.CurrentRow.Cells[5].Value.ToString();

            textCedula.Enabled = false;
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtDireccion.Enabled = false;
            txtTelefono.Enabled = false;
            txtCorreo.Enabled = false;

        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            
            string Mensaje = string.Empty;
            persona objpersona = new persona()
            {
                cedula_persona = textCedula.Text,
                nombre_persona = txtNombre.Text,
                apellido_persona = txtApellido.Text,
                telefono = txtTelefono.Text,
                direccion = txtDireccion.Text,
                correo = txtCorreo.Text,

            };
            
            bool Respuesta = new N_Personanombre().Editar(objpersona, out Mensaje);
            if (Respuesta)
            {
              
                
            }


        }

        private void tabla_Clientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
