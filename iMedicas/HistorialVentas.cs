using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using MetroFramework.Controls;

namespace iMedicas
{
    public partial class HistorialVentas : MetroForm
    {
        public HistorialVentas()
        {
            InitializeComponent();
        }

        Consultas sql = new Consultas();
        private void HistorialVentas_Load(object sender, EventArgs e)
        {
            dgvVentas.DataSource = sql.ObtenerVentas();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if(IdVenta.Text != "")
            {
                sql.CancelarVenta(IdVenta.Text);

            }

            dgvVentas.DataSource = sql.ObtenerVentas();
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {

        }

        private void dgvVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvVentas.Rows[e.RowIndex];
            if(fila != null)
            {
                IdVenta.Text = fila.Cells[0].Value.ToString();
            }
            
        }
    }
}
