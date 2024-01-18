using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketManager.Presentacion
{
    public partial class FrmRegistrarCompra : Form
    {
        public FrmRegistrarCompra()
        {
            InitializeComponent();
            
            



        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }

        private void horafecha_Click(object sender, EventArgs e)
        {


        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            fechacompra.Text = DateTime.Now.ToLongTimeString() + " - " + DateTime.Now.ToString("dd/MM/yyyy");

        }

        private void FrmRegistrarCompra_Load(object sender, EventArgs e)
        {
            txtCedulaContacto.Focus();
        }
    }
}
