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
    public partial class Inicio : MetroForm
    {
        Consultas sql = new Consultas();
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Cliente clientes = new Cliente();
            clientes.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sql.PruebaConexion();
        }
    }
}
