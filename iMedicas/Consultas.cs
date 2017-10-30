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

        public void Insertar(string id, string nombre, string telefono, string direccion, string email)
        {
            Crearconexion();

            SqlCommand cmd = new SqlCommand("insert into Cliente (Id_Cliente, Nombre_Cliente,Telefono,Direccion,Email) values (@Id_Cliente,@Nombre_Cliente,@Telefono,@Direccion,@Email)", conexion);
            cmd.Parameters.Add("@Id_Cliente",System.Data.SqlDbType.Int);
            cmd.Parameters.Add("@Nombre_Cliente", System.Data.SqlDbType.VarChar);
            cmd.Parameters.Add("@Telefono", System.Data.SqlDbType.VarChar);
            cmd.Parameters.Add("@Direccion", System.Data.SqlDbType.VarChar);
            cmd.Parameters.Add("@Email", System.Data.SqlDbType.VarChar);

            cmd.Parameters["@Id_Cliente"].Value = id;
            cmd.Parameters["@Nombre_Cliente"].Value = nombre;
            cmd.Parameters["@Telefono"].Value = telefono;
            cmd.Parameters["@Direccion"].Value = direccion;
            cmd.Parameters["@Email"].Value = email;

            try
            {
                conexion.Open();
                int filas = cmd.ExecuteNonQuery();
                conexion.Close();
            }
            catch(Exception ex)
            {
                conexion.Close();
                MessageBox.Show(ex.ToString());
            }
            

            

        }

        public void Eliminar(string id)
        {
            Crearconexion();
            try
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand(string.Format("delete from Cliente where Id_Cliente = {0}", id), conexion);
                cmd.ExecuteNonQuery();
                conexion.Close();
            }
            catch(Exception ex)
            {
                conexion.Close();
                MessageBox.Show(ex.ToString());
            }

        }

        public DataTable selectSimple(string consulta, string tabla, string condicion ="")
        {
            Crearconexion();
            conexion.Open();
            SqlDataAdapter ad = new SqlDataAdapter(string.Format("Select {0} from {1} {2}",consulta,tabla,condicion), conexion);
            SqlCommandBuilder cmd = new SqlCommandBuilder(ad);
            ds = new DataSet();
            ad.Fill(ds);
            conexion.Close();
            return ds.Tables[0];
        }

        public string selectDatoSimple(string consulta, string tabla, string condicion ="")
        {
            Crearconexion();
            string query = string.Format("select {0} from {1} {2}", consulta, tabla, condicion);

            SqlCommand cmd = new SqlCommand(query, conexion);
            conexion.Open();
            string sdr = cmd.ExecuteScalar().ToString();
            conexion.Close();
            return sdr;
        }

    }
}
