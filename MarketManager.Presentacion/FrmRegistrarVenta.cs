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
    public partial class FrmRegistrarVenta : Form
    {
        public FrmRegistrarVenta()
        {
            InitializeComponent();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            fechacompra.Text = DateTime.Now.ToLongTimeString() + " - " + DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmRegistrarVenta_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }
    }
}
