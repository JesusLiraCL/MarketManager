using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using MarketManager.Entidad;
using MarketManager.Negocio;

namespace MarketManager.Presentacion
{

    public partial class FrmMenu : Form
    {
        private static usuario UsuarioActual;
        private IconButton currentBtn;
        private Panel LeftBorderBtn;


        public FrmMenu(usuario objusuario)
        {
            UsuarioActual = objusuario;
            InitializeComponent();
            LeftBorderBtn = new Panel();
            LeftBorderBtn.Size = new Size(7, 60);

            ocultar_paneles();
        }

        public FrmMenu()
        {
        }

        public void ocultar_paneles()
        {
            panel_reportes.Visible = false;
            panel_inventario.Visible = false;
            panel_perfil.Visible = false;
        }

        public void abrir_panel(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                submenu.Visible = true;
            }
            else submenu.Visible = false;

        }

        public void abrir_formulario(object formhija)
        {
            if (this.panel_contenedor.Controls.Count > 0)
                this.panel_contenedor.Controls.RemoveAt(0);

            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel_contenedor.Controls.Clear();
            this.panel_contenedor.Controls.Add(panel_perfil);

            this.panel_contenedor.Controls.Add(fh);
            this.panel_contenedor.Tag = fh;
            fh.Show();
            fh.SendToBack();
        }

        private void bt_reportes_Click(object sender, EventArgs e)
        {
            abrir_panel(panel_reportes);
        }

        private void bt_inventario_Click(object sender, EventArgs e)
        {
            abrir_panel(panel_inventario);
        }

        private void fechahora_Tick(object sender, EventArgs e)
        {
            fecha.Text = DateTime.Now.ToLongDateString();
            hora.Text = DateTime.Now.ToLongTimeString();
        }

        private void fecha_Click(object sender, EventArgs e)
        {

        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            //Cargar nombre del usuario
            List<persona> TEST = new N_Personanombre().Listar();
            persona nombrepersona = new N_Personanombre().Listar().Where(u => u.cedula_persona.Equals(UsuarioActual.cedula)).FirstOrDefault();

            if (UsuarioActual.codigo_rol.Equals("1"))
            {
                abrir_formulario(new FrmUsuarios());
            }

            else if (UsuarioActual.codigo_rol.Equals("2"))
            {
                bt_compra.Visible = false;   
                bt_inventario.Visible = false;
                bt_usuarios.Visible = false;
                bt_proveedores.Visible = false;
                
            }
            else if (UsuarioActual.codigo_rol.Equals("3"))
            {
                bt_compra.Visible = false;
                bt_empleados.Visible = false;
                bt_reportes.Visible = false;
                bt_inventario.Visible = false;
                bt_usuarios.Visible = false;
                bt_proveedores.Visible = false;

                abrir_formulario(new FrmRegistrarVenta());
            }

            if (nombrepersona != null) 
            {
                bt_usuario.Text = nombrepersona.nombre_persona + " " + nombrepersona.apellido_persona + " " + UsuarioActual.nombre_rol;
            }
            

        }

        private void bt_compra_Click(object sender, EventArgs e)
        {
            abrir_formulario(new FrmRegistrarCompra());
            
        }

        private void bt_venta_Click(object sender, EventArgs e)
        {
            abrir_formulario(new FrmRegistrarVenta());

        }

        private void bt_empleados_Click(object sender, EventArgs e)
        {
            abrir_formulario(new FrmEmpleados());

        }

        private void bt_clientes_Click(object sender, EventArgs e)
        {
            abrir_formulario(new FrmClientes());
        }

        private void bt_sub_ventas_Click(object sender, EventArgs e)
        {
            abrir_formulario(new FrmReporteVentas());
        }

        private void bt_sub_compras_Click(object sender, EventArgs e)
        {
            abrir_formulario(new FrmReporteCompras());
            
        }

        private void bt_sub_productos_Click(object sender, EventArgs e)
        {
            abrir_formulario(new FrmProductos());
        }

        private void bt_sub_movimientos_Click(object sender, EventArgs e)
        {
            abrir_formulario(new FrmMovimientos());
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bt_acerca_Click(object sender, EventArgs e)
        {
            abrir_formulario(new FrmAcercade());
        }

        private void panel_contenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bt_usuarios_Click(object sender, EventArgs e)
        {
            abrir_formulario(new FrmUsuarios());

        }

        private void bt_proveedores_Click(object sender, EventArgs e)
        {
            abrir_formulario(new FrmProveedores());
        }

        private void titulo_Click(object sender, EventArgs e)
        {
            if (this.panel_contenedor.Controls.Count > 0)
                this.panel_contenedor.Controls.RemoveAt(0);
        }

        private void bt_usuario_Click(object sender, EventArgs e)
        {
            abrir_panel(panel_perfil);
            panel_perfil.BringToFront();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel_perfil.Visible = false;
        }

        private void bt_usuario_MouseEnter(object sender, EventArgs e)
        {
            abrir_panel(panel_perfil);
            timer1.Stop();
        }

        private void bt_usuario_MouseLeave(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void bt_perfil_MouseEnter(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void bt_perfil_MouseLeave(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void bt_cerrar_MouseEnter(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void bt_cerrar_MouseLeave(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void bt_cerrar_Click(object sender, EventArgs e)
        {
            string text = "¿Está seguro que desea cerrar sesión?";

            DialogResult result = MessageBox.Show(text,
                "Cerrando sesión...",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                FrmLogin frm = new FrmLogin();
                frm.Show();
                this.Close();
            }
           
        }
    }
}
