﻿using System;
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
    public partial class Clientes : MetroForm
    {
        Consultas sql = new Consultas();
        public Clientes()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            dgvClientes.DataSource = sql.MostrarDatos("Cliente");
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvClientes.Rows[e.RowIndex];
            txbId.Text = Convert.ToString(fila.Cells[0].Value);
            txbNombre.Text = Convert.ToString(fila.Cells[1].Value);
            txbTelefono.Text = Convert.ToString(fila.Cells[2].Value);
            txbDireccion.Text = Convert.ToString(fila.Cells[3].Value);
            txbEmail.Text = Convert.ToString(fila.Cells[4].Value);
            txbId.Enabled = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string id = txbId.Text;
            if (Validaciones() && ValidarIdRepetido(id))
            {
                try
                {
                    sql.InsertarClientes(id, txbNombre.Text, txbTelefono.Text, txbDireccion.Text, txbEmail.Text);
                   // MetroMessageBox.Show(this, "La Operacion se realizo con exito");
                    dgvClientes.DataSource = sql.MostrarDatos("Cliente");
                    txbDireccion.Text = txbEmail.Text = txbId.Text = txbNombre.Text = txbTelefono.Text = "";
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
                sql.EliminarClientes(txbId.Text);
                //MetroMessageBox.Show(this, "Se elimino la fila");
                dgvClientes.DataSource = sql.MostrarDatos("Cliente");
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
                            sql.ActualizarClientes(id, txbNombre.Text, txbTelefono.Text, txbDireccion.Text, txbEmail.Text);
                            //MetroMessageBox.Show(this, "La Operacion se realizo con exito");
                            dgvClientes.DataSource = sql.MostrarDatos("Cliente");
                            txbDireccion.Text = txbEmail.Text = txbId.Text = txbNombre.Text = txbTelefono.Text = "";
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
            if (txbDireccion.Text != "" &&
                txbEmail.Text != "" &&
                txbId.Text != "" &&
                txbNombre.Text != "" &&
                txbTelefono.Text != "")
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
            foreach (DataGridViewRow row in dgvClientes.Rows)
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
    }
}
