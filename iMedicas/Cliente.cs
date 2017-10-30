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
    public partial class Cliente : MetroForm
    {
        Consultas sql = new Consultas();
        public Cliente()
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
            
        }
    }
}
