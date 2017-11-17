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
using MetroFramework.Controls;

namespace iMedicas
{
    public partial class Login : MetroForm
    {
        Consultas sql = new Consultas();
        public Login()
        {
            InitializeComponent();
        }

        public string Encriptar(string contraseña)
        {
            System.Security.Cryptography.HashAlgorithm valorHash = new System.Security.Cryptography.SHA1CryptoServiceProvider();

            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(contraseña);

            byte[] byteHash = valorHash.ComputeHash(bytes);

            valorHash.Clear();

            return (Convert.ToBase64String(byteHash));
        }

        public bool comprobarContraseña(string contraseña)
        {
            string contraseña2 = sql.selectDatoSimple("Contraseña", "Usuarios", "Where Usuario like '%"+txbUsuario.Text+"%'");
            if (contraseña == contraseña2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool comprobarUsuario(string Usuario)
        {
            try
            {
                string contraseña2 = sql.selectDatoSimple("Contraseña", "Usuarios", "Where Usuario like '%" + txbUsuario.Text + "%'");
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
            
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txbUsuario.Text != "" || txbContraseña.Text != "")
            {
                if (comprobarUsuario(txbUsuario.Text))
                {
                    if (comprobarContraseña(Encriptar(txbContraseña.Text)))
                    {
                        Inicio inicio = new Inicio();
                        this.Hide();
                        inicio.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Contraseña Incorrecta");
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "Usuario Incorrecto");
                }
            }
            else
            {
                MetroMessageBox.Show(this, "No Puedes Dejar Campos Vacios");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            sql.PruebaConexion();
        }

    }
}
