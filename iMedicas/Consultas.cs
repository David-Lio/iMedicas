using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;
using MetroFramework.Controls;

namespace iMedicas
{
    class Consultas
    {
        SqlConnectionStringBuilder stringconexion = new SqlConnectionStringBuilder();
        private SqlConnection conexion;
        DataSet ds;

        private void Crearconexion()
        {
            stringconexion.ConnectionString = "Data Source=DESKTOP-F2G33N0\\TALLERBASEDATOS;Initial Catalog=iMedicas;";
            stringconexion.UserID = "sa";
            stringconexion.Password = "123456";
            conexion = new SqlConnection(stringconexion.ConnectionString);
        }

        public void PruebaConexion()
        {
            Crearconexion();
            try
            {
                conexion.Open();
                MessageBox.Show("Se realizo la Conexion Con Exito");
                conexion.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public DataTable MostrarDatos()
        {
            Crearconexion();
            try
            {
                conexion.Open();
                SqlDataAdapter ad = new SqlDataAdapter("Select * from Cliente", conexion);
                SqlCommandBuilder cmd = new SqlCommandBuilder(ad);
                ds = new DataSet();
                ad.Fill(ds);
                conexion.Close();
                return ds.Tables[0];

            }
            catch (Exception e)
            {
                MessageBox.Show("Hubo un error " + e);
                return null;
            }



        }
    }
}
