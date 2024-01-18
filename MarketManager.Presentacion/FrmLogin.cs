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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1Ingresar_Click(object sender, EventArgs e)
        {
            
            usuario ousuario = new N_usuario().Listar().Where(u => u.nombre_usuario == textUsuario.Text && u.contraseña == textContraseña.Text).FirstOrDefault();

            if (ousuario != null && ousuario.nombre_usuario == textUsuario.Text && ousuario.contraseña == textContraseña.Text)
            {
                FrmMenu formulario = new FrmMenu(ousuario);
                formulario.Show();
                this.Hide();


            }
            else if (ousuario == null && string.IsNullOrEmpty(textUsuario.Text) || string.IsNullOrEmpty(textContraseña.Text))
            {
                
                MessageBox.Show("Uno de los campos esta vacio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textUsuario.Text = string.Empty;
                textContraseña.Text = string.Empty;
                textUsuario.Focus();

            }
            
            else if (ousuario == null)
            {

                MessageBox.Show("Nombre de usuario o contraseña incorrectos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textUsuario.Text = string.Empty;
                textContraseña.Text = string.Empty;
                textUsuario.Focus();

            }
            
            

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textContraseña_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
