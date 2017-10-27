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
    }
}
