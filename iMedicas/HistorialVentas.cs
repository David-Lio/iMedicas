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
            if (IdVenta.Text != "")
            {
                if(Estatus.Text != "Cancelada")
                {
                    sql.CancelarVenta(IdVenta.Text);
                    dgvProductos.DataSource = sql.selectSimple("Id_Producto,Existencia", "Producto");
                    foreach (DataGridViewRow row in dgvProductosVenta.Rows)
                    {
                        foreach (DataGridViewRow row2 in dgvProductos.Rows)
                        {
                            int idProductoVenta = Convert.ToInt16(row.Cells[0].Value);
                            int idProductoInventario = Convert.ToInt16(row2.Cells[0].Value);
                            if (idProductoVenta == idProductoInventario)
                            {
                                int existencia = Convert.ToInt16(row2.Cells[1].Value) + Convert.ToInt16(row.Cells[1].Value);
                                sql.ActualizarExistencias(idProductoVenta.ToString(), existencia);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Esta venta ya ha sido cancelada");
                }
                

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
                Estatus.Text = fila.Cells[2].Value.ToString();
                dgvProductosVenta.DataSource = sql.selectSimple("Id_Producto,Cantidad", "DetallesVenta", "Where Id_Venta=" + IdVenta.Text);
            }
            
        }
    }
}
