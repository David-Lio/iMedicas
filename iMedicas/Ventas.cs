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
    public partial class Ventas : MetroForm
    {
        Consultas sql = new Consultas();
        string id_cliente;
        string x = "";
        public Ventas()
        {
            InitializeComponent();
        }

        
        

        private void Ventas_Load(object sender, EventArgs e)
        {
            cbClientes.DisplayMember = "Nombre_Cliente";
            cbClientes.ValueMember = "Id_Cliente";

            cbClientes.DataSource = sql.selectSimple("Id_Cliente,Nombre_Cliente", "Cliente");

            x = 1 + sql.ObtenerVentas();
            lblVenta.Text = "Venta Numero: " + x;

            cbProductos.ValueMember = "Id_Producto";
            cbProductos.DisplayMember = "Descripcion";
            cbProductos.DataSource = sql.selectSimple("Id_Producto,Descripcion", "Producto");
        }

        private void cbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            id_cliente = cbClientes.SelectedValue.ToString();
            string tabla = "Cliente";
            string condicion = "where Id_Cliente =" + id_cliente;
            string telefono = sql.selectDatoSimple("Telefono", tabla, condicion);
            string direccion = sql.selectDatoSimple("Direccion", tabla, condicion);
            string email = sql.selectDatoSimple("Email", tabla, condicion);

            txbTelefono.Text = telefono;
            txbDireccion.Text = direccion;
            txbEmail.Text = email;

        }

        private void cbProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbDescripcion.Text = sql.selectDatoSimple("Descripcion", "Producto", "Where Id_Producto =" + cbProductos.SelectedValue.ToString());
            txbPrecio.Text = sql.selectDatoSimple("Precio_Venta", "Producto", "Where Id_Producto =" + cbProductos.SelectedValue.ToString());
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(txbPrecio.Text != "" &&
                txbDescripcion.Text != "")
            {
                dgvProductos.Rows.Add(cbProductos.SelectedValue.ToString(), txbDescripcion.Text, txbPrecio.Text);
            }

            total();
        }

        private void total()
        {
            int total = 0;
            foreach (DataGridViewRow row in dgvProductos.Rows)
            {
                if (row != null)
                {
                    total += Convert.ToInt16(row.Cells[2].Value);

                }
            }

            lblTotal.Text = total.ToString();
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {

            try
            {
                if (x != null && dgvProductos.Rows.Count != 0)
                {
                    sql.InsertarVenta(x, id_cliente, lblTotal.Text);

                    foreach (DataGridViewRow row in dgvProductos.Rows)
                    {
                        if (row.Cells[0].Value != null)
                        {
                            string valor = row.Cells[0].Value.ToString();
                            sql.InsertarDetallesVenta(x, valor);
                        }
                    }
                }


                MetroMessageBox.Show(this, "Se realizo la venta con el Id: " + x);
                this.Close();
            }
            catch(Exception ex)
            {
                MetroMessageBox.Show(this, "No se pudo realizar la venta");
            }


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvProductos.SelectedRows.Count > 0)
            {
                dgvProductos.Rows.RemoveAt(this.dgvProductos.SelectedRows[0].Index);
            }
        }
    }
}
