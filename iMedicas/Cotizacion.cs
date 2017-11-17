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
    public partial class Cotizacion : MetroForm
    {
        Consultas sql = new Consultas();
        public Cotizacion()
        {
            InitializeComponent();
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            cbClientes.DisplayMember = "Nombre_Cliente";
            cbClientes.ValueMember = "Id_Cliente";

            cbClientes.DataSource = sql.selectSimple("Id_Cliente,Nombre_Cliente","Cliente");
        }

        private void cbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = cbClientes.SelectedValue.ToString();
            string tabla = "Cliente";
            string condicion = "where Id_Cliente =" + id;
            string telefono = sql.selectDatoSimple("Telefono",tabla,condicion);
            string direccion = sql.selectDatoSimple("Direccion", tabla, condicion);
            string email = sql.selectDatoSimple("Email", tabla, condicion);

            txbTelefono.Text = telefono;
            txbDireccion.Text = direccion;
            txbEmail.Text = email;

        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            Ventas venta = new Ventas(cbClientes.SelectedValue.ToString());
            venta.Show();
        }
    }
}
