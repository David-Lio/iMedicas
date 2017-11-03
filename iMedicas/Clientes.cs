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
            dgvClientes.DataSource = sql.MostrarDatos();
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvClientes.Rows[e.RowIndex];
            txbId.Text = Convert.ToString(fila.Cells[0].Value);
            txbNombre.Text = Convert.ToString(fila.Cells[1].Value);
            txbTelefono.Text =  Convert.ToString(fila.Cells[2].Value);
            txbDireccion.Text = Convert.ToString(fila.Cells[3].Value);
            txbEmail.Text = Convert.ToString(fila.Cells[4].Value);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string id = txbId.Text;
            if (Validaciones())
            {
                try
                {
                    sql.Insertar(id, txbNombre.Text, txbTelefono.Text, txbDireccion.Text, txbEmail.Text);
                    MetroMessageBox.Show(this, "La Operacion se realizo con exito");
                    dgvClientes.DataSource = sql.MostrarDatos();
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
            if (true)
            {
                if (txbId.Text != "")
                {
                    sql.Eliminar(txbId.Text);
                    MetroMessageBox.Show(this, "Se elimino la fila");
                    sql.MostrarDatos();
                    dgvClientes.DataSource = sql.MostrarDatos();
                }
                else
                {
                    MetroMessageBox.Show(this, "No se pudo efectuar la eliminacion");
                }
            }
            
        }

        public Boolean Validaciones()
        {
            if(txbDireccion.Text != "" ||
                txbEmail.Text != "" ||
                txbId.Text != "" ||
                txbNombre.Text != "" ||
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
    }
}
