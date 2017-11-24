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


namespace iMedicas
{
    public partial class Productos : MetroForm
    {
        public Productos()
        {
            InitializeComponent();
        }
        Consultas sql = new Consultas();


        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvProductos.Rows[e.RowIndex];
            txbId.Text = Convert.ToString(fila.Cells[0].Value);
            txbDescripcion.Text = Convert.ToString(fila.Cells[1].Value);
            txbPrecio.Text = Convert.ToString(fila.Cells[2].Value);
            cbTipo.Text = Convert.ToString(fila.Cells[3].Value);
            txbId.Enabled = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string id = txbId.Text;
            if (Validaciones() && ValidarIdRepetido(id))
            {
                try
                {
                    sql.InsertarProductos(id, txbDescripcion.Text, txbPrecio.Text, cbTipo.SelectedItem.ToString());
                    //MetroMessageBox.Show(this, "La Operacion se realizo con exito");
                    dgvProductos.DataSource = sql.MostrarDatos("Producto");
                    txbDescripcion.Text = txbPrecio.Text = txbId.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.ToString());
                }
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txbId.Text != "")
            {
                try
                {
                    sql.EliminarProducto(txbId.Text);
                    //MetroMessageBox.Show(this, "Se elimino la fila");
                    dgvProductos.DataSource = sql.MostrarDatos("Producto");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("No se pudo eliminar el producto porque esta relacionado con una venta");
                }
                
            }
            else
            {
                MetroMessageBox.Show(this, "No se pudo efectuar la eliminacion");
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            if (true)
            {
                if (txbId.Text != "")
                {
                    string id = txbId.Text;
                    if (Validaciones())
                    {

                        try
                        {
                            sql.ActualizarProductos(id, txbDescripcion.Text,txbPrecio.Text,cbTipo.SelectedItem.ToString());
                           // MetroMessageBox.Show(this, "La Operacion se realizo con exito");
                            dgvProductos.DataSource = sql.MostrarDatos("Producto");
                            txbDescripcion.Text = txbPrecio.Text = txbId.Text = "";
                            txbId.Enabled = true;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(this, ex.ToString());
                        }
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "No se pudo efectuar la Actualizacion");
                }
            }

        }

        public Boolean Validaciones()
        {
            if (txbDescripcion.Text != "" &&
                txbPrecio.Text != "" &&
                txbId.Text != "" &&
                cbTipo.SelectedItem.ToString() != "")
            {
                return true;
            }
            else
            {
                MetroMessageBox.Show(this, "Debes Llenar Todos Los Campos");
                return false;
            }
        }

        public Boolean ValidarIdRepetido(string id)
        {
            foreach (DataGridViewRow row in dgvProductos.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    if (row.Cells[0].Value.ToString() == id)
                    {
                        MetroMessageBox.Show(this, "No Se Pueden Repetir Id's");
                        return false;
                    }
                }

            }
            return true;
        }

        private void txbId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            dgvProductos.DataSource = sql.MostrarDatos("Producto");
        }
    }
}
