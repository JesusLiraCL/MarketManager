using MarketManager.Entidad;
using MarketManager.Negocio;
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
    public partial class FrmReporteCompras : Form
    {
        public FrmReporteCompras()
        {
            InitializeComponent();
        }

        private void FrmReporteCompras_Load(object sender, EventArgs e)
        {
            List<compra> lista_compra = new N_compra().Listar();

            foreach (compra item in lista_compra)
            {
                tabla_compra.Rows.Add(new object[] {
                    item.id_compra,
                    item.codigo_proveedor,
                    item.cedula_usuario,
                    item.fecha,
                    item.monto});
            }
        }

        private void tabla_productos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
