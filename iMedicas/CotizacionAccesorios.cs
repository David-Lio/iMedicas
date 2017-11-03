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
    public partial class CotizacionAccesorios : MetroForm
    {
        public CotizacionAccesorios()
        {
            InitializeComponent();
        }

        Consultas sql = new Consultas();

        private void cbAccesorios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CotizacionAccesorios_Load(object sender, EventArgs e)
        {
            cbAccesorios.DisplayMember = "Descripcion";
            cbAccesorios.ValueMember = "Id_Accesorio";

            cbAccesorios.DataSource = sql.selectSimple("Id_Accesorio,Descripcion", "Accesorios");
        }
    }
}
