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
using MetroFramework.Controls;
using MetroFramework.Forms;

namespace iMedicas
{
    public partial class Producto : MetroForm
    {
        Consultas sql = new Consultas();
        public Producto()
        {
            InitializeComponent();
        }

        private void Microscopios_Load(object sender, EventArgs e)
        {
            dgvMicroscopios.DataSource = sql.MostrarDatos("Microscopio");
        }

        public Boolean Validaciones()
        {
            if (txbId.Text != "" &&
                txbModelo.Text != "" &&
                txbPrecioR.Text != "" &&
                txbPrecioV.Text != ""
                )
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
            foreach (DataGridViewRow row in dgvMicroscopios.Rows)
            {
                if (row.Cells[0].Value.ToString() == id)
                {
                    MetroMessageBox.Show(this, "No Se Pueden Repetir Id's");
                    return false;
                }
            }
            return true;
        }

        private void dgvMicroscopios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvMicroscopios.Rows[e.RowIndex];
            txbId.Text = Convert.ToString(fila.Cells[0].Value);
            txbModelo.Text = Convert.ToString(fila.Cells[1].Value);
            txbPrecioV.Text = Convert.ToString(fila.Cells[2].Value);
            txbPrecioV.Text = Convert.ToString(fila.Cells[3].Value);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string id = txbId.Text;
            if (Validaciones() && ValidarIdRepetido(id))
            {
                try
                {
                    sql.InsertarMicroscopios(id, txbModelo.Text, txbPrecioV.Text, txbPrecioR.Text);
                    MetroMessageBox.Show(this, "La Operacion se realizo con exito");
                    dgvMicroscopios.DataSource = sql.MostrarDatos("Microscopio");
                    txbId.Text = txbModelo.Text = txbPrecioR.Text = txbPrecioV.Text = "";
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
                sql.EliminarMicroscopios(txbId.Text);
                MetroMessageBox.Show(this, "Se elimino la fila");
                dgvMicroscopios.DataSource = sql.MostrarDatos("Microscopio");
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
                            sql.ActualizarMicroscopios(id, txbModelo.Text, txbPrecioV.Text, txbPrecioR.Text);
                            MetroMessageBox.Show(this, "La Operacion se realizo con exito");
                            dgvMicroscopios.DataSource = sql.MostrarDatos("Microscopio");
                            txbId.Text = txbModelo.Text = txbPrecioR.Text = txbPrecioV.Text = "";
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

        private void txbId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
