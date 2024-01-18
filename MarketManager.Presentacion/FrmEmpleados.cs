using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MarketManager.Entidad;
using MarketManager.Negocio;

namespace MarketManager.Presentacion

{
    public partial class FrmEmpleados : Form
    {
        public FrmEmpleados()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void tabla_productos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            txtCedulaEmpleado.Focus();
            List<empleado> lista_empleado = new N_empleado().Listar();

            foreach (empleado item in lista_empleado)
            {
                tabla_Empleados.Rows.Add(new object[] {
                    item.cedula_empleado,
                    item.nombre_persona,
                    item.direccion,
                    item.telefono,
                    item.correo,
                    item.nombre_cargo});
            }
        }

        private void tabla_Empleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCedulaEmpleado.Text = tabla_Empleados.CurrentRow.Cells[0].Value.ToString();
            txtNombreEmpleado.Text = tabla_Empleados.CurrentRow.Cells[1].Value.ToString();
            txtDireccionEmpleado.Text = tabla_Empleados.CurrentRow.Cells[2].Value.ToString();
            txtTelefonoEmpleado.Text = tabla_Empleados.CurrentRow.Cells[3].Value.ToString();
            txtCorreoEmpleado.Text = tabla_Empleados.CurrentRow.Cells[4].Value.ToString();
            textCargoEmpleado.Text = tabla_Empleados.CurrentRow.Cells[5].Value.ToString();

            txtCedulaEmpleado.Enabled = false;
            txtNombreEmpleado.Enabled = false;
            txtDireccionEmpleado.Enabled = false;
            txtTelefonoEmpleado.Enabled = false;
            txtCorreoEmpleado.Enabled = false;
            textCargoEmpleado.Enabled = false;
        }
    }
}

