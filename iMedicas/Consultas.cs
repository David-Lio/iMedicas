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
            stringconexion.ConnectionString = "Data Source=DESKTOP-PAISPB6;Initial Catalog=iMedicas;";
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

        public DataTable MostrarDatos(string tabla)
        {
            Crearconexion();
            try
            {
                conexion.Open();
                SqlDataAdapter ad = new SqlDataAdapter(string.Format("Select * from {0}",tabla), conexion);
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

        public void InsertarClientes(string id, string nombre, string telefono, string direccion, string email)
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

        public void ActualizarClientes(string id, string nombre, string telefono, string direccion, string email)
        {
            Crearconexion();

            SqlCommand cmd = new SqlCommand("Update Cliente set Nombre_Cliente = @Nombre_Cliente,Telefono = @Telefono,Direccion = @Direccion,Email = @Email where Id_Cliente ="+id, conexion);

            cmd.Parameters.Add("@Nombre_Cliente", System.Data.SqlDbType.VarChar);
            cmd.Parameters.Add("@Telefono", System.Data.SqlDbType.VarChar);
            cmd.Parameters.Add("@Direccion", System.Data.SqlDbType.VarChar);
            cmd.Parameters.Add("@Email", System.Data.SqlDbType.VarChar);

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
            catch (Exception ex)
            {
                conexion.Close();
                MessageBox.Show(ex.ToString());
            }




        }

        public void EliminarClientes(string id)
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

        public void InsertarProductos(string id, string descripcion, string precio_venta, string tipo, string existencia)
        {
            Crearconexion();

            SqlCommand cmd = new SqlCommand("insert into Producto (Id_Producto, Descripcion,Precio_Venta,Tipo_Producto,Existencia) values (@Id_Producto,@Descripcion,@Precio_Venta,@Tipo_Producto,@Existencia)", conexion);
            cmd.Parameters.Add("@Id_Producto", System.Data.SqlDbType.Int);
            cmd.Parameters.Add("@Descripcion", System.Data.SqlDbType.VarChar);
            cmd.Parameters.Add("@Precio_Venta", System.Data.SqlDbType.VarChar);
            cmd.Parameters.Add("@Tipo_Producto", System.Data.SqlDbType.VarChar);
            cmd.Parameters.Add("@Existencia", System.Data.SqlDbType.VarChar);


            cmd.Parameters["@Id_Producto"].Value = id;
            cmd.Parameters["@Descripcion"].Value = descripcion;
            cmd.Parameters["@Precio_Venta"].Value = precio_venta;
            cmd.Parameters["@Tipo_Producto"].Value = tipo;
            cmd.Parameters["@Existencia"].Value = existencia;

            try
            {
                conexion.Open();
                int filas = cmd.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception ex)
            {
                conexion.Close();
                MessageBox.Show(ex.ToString());
            }




        }

        public void ActualizarProductos(string id, string descripcion, string precio_venta, string tipo, string existencia)
        {
            Crearconexion();

            SqlCommand cmd = new SqlCommand("Update Producto set Descripcion = @Descripcion,Precio_Venta = @Precio_Venta,Tipo_Producto = @Tipo_Producto, Existencia = @Existencia where Id_Producto =" + id, conexion);

            cmd.Parameters.Add("@Descripcion", System.Data.SqlDbType.VarChar);
            cmd.Parameters.Add("@Precio_Venta", System.Data.SqlDbType.VarChar);
            cmd.Parameters.Add("@Tipo_Producto", System.Data.SqlDbType.VarChar);
            cmd.Parameters.Add("@Existencia", System.Data.SqlDbType.VarChar);

            cmd.Parameters["@Descripcion"].Value = descripcion;
            cmd.Parameters["@Precio_Venta"].Value = precio_venta;
            cmd.Parameters["@Tipo_Producto"].Value = tipo;
            cmd.Parameters["@Existencia"].Value = existencia;

            try
            {
                conexion.Open();
                int filas = cmd.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception ex)
            {
                conexion.Close();
                MessageBox.Show(ex.ToString());
            }




        }

        public void ActualizarExistencias(string id, int existencia)
        {
            Crearconexion();

            SqlCommand cmd = new SqlCommand("Update Producto set Existencia = @Existencia where Id_Producto =" + id, conexion);
            cmd.Parameters.Add("@Existencia", System.Data.SqlDbType.VarChar);
            cmd.Parameters["@Existencia"].Value = existencia;

            try
            {
                conexion.Open();
                int filas = cmd.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception ex)
            {
                conexion.Close();
                MessageBox.Show(ex.ToString());
            }




        }

        public void EliminarProducto(string id)
        {
            Crearconexion();
            try
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand(string.Format("delete from Producto where Id_Producto = {0}", id), conexion);
                cmd.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception ex)
            {
                conexion.Close();
                MessageBox.Show("No se puede eliminar el producto porque esta relacionado con una venta");
            }

        }

        public void InsertarVenta(string Id_Venta, string Id_Cliente, string total)
        {
            Crearconexion();

            SqlCommand cmd = new SqlCommand("insert into Venta (Id_Venta,Id_Cliente,Total,Estado) values (@Id_Venta,@Id_Cliente,@Total,@Estado)", conexion);
            cmd.Parameters.Add("@Id_Venta", System.Data.SqlDbType.Int);
            cmd.Parameters.Add("@Id_Cliente", System.Data.SqlDbType.Int);
            cmd.Parameters.Add("@Total", System.Data.SqlDbType.VarChar);
            cmd.Parameters.Add("@Estado", System.Data.SqlDbType.VarChar);

            cmd.Parameters["@Id_Venta"].Value = Id_Venta;
            cmd.Parameters["@Id_Cliente"].Value = Id_Cliente;
            cmd.Parameters["@Total"].Value = total;
            cmd.Parameters["@Estado"].Value = "Activa";

            try
            {
                conexion.Open();
                int filas = cmd.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception ex)
            {
                conexion.Close();
                MessageBox.Show(ex.ToString());
            }




        }

        public void InsertarDetallesVenta(string Id_Venta, string Id_Producto,string Cantidad)
        {
            Crearconexion();

            SqlCommand cmd = new SqlCommand("insert into DetallesVenta (Id_Venta,Id_Producto,Cantidad) values (@Id_Venta,@Id_Producto,@Cantidad)", conexion);
            cmd.Parameters.Add("@Id_Venta", System.Data.SqlDbType.Int);
            cmd.Parameters.Add("@Id_Producto", System.Data.SqlDbType.Int);
            cmd.Parameters.Add("@Cantidad", System.Data.SqlDbType.Int);

            cmd.Parameters["@Id_Venta"].Value = Id_Venta;
            cmd.Parameters["@Id_Producto"].Value = Id_Producto;
            cmd.Parameters["@Cantidad"].Value = Cantidad;

            try
            {
                conexion.Open();
                int filas = cmd.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception ex)
            {
                conexion.Close();
                MessageBox.Show(ex.ToString());
            }




        }

        public void CancelarVenta(string Id_Venta)
        {
            Crearconexion();

            SqlCommand cmd = new SqlCommand("Update Venta set Estado = @Estado where Id_Venta =" + Id_Venta, conexion);
            cmd.Parameters.Add("@Estado", System.Data.SqlDbType.VarChar);
            cmd.Parameters["@Estado"].Value = "Cancelada";

            try
            {
                conexion.Open();
                int filas = cmd.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception ex)
            {
                conexion.Close();
                MessageBox.Show(ex.ToString());
            }
        }


        public void RegresarExistencias()
        {

        }

        public string ContadorVentas()
        {
            Crearconexion();
            string query = string.Format("Select Count(Id_Venta) from Venta");

            SqlCommand cmd = new SqlCommand(query, conexion);
            conexion.Open();
            string sdr = cmd.ExecuteScalar().ToString();
            conexion.Close();
            return sdr;
        }

        public string ContadorProductos(string Id_Venta)
        {
            Crearconexion();
            string query = string.Format("Select Count("+Id_Venta+") from DetallesVenta where Id_Venta ="+Id_Venta);

            SqlCommand cmd = new SqlCommand(query, conexion);
            conexion.Open();
            string sdr = cmd.ExecuteScalar().ToString();
            conexion.Close();
            return sdr;
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

        public DataTable ObtenerVentas()
        {
            Crearconexion();
            conexion.Open();
            SqlDataAdapter ad = new SqlDataAdapter("select Id_Venta,Nombre_Cliente,Estado,Total from Venta,Cliente where Venta.Id_Cliente = Cliente.Id_Cliente", conexion);
            SqlCommandBuilder cmd = new SqlCommandBuilder(ad);
            ds = new DataSet();
            ad.Fill(ds);
            conexion.Close();
            return ds.Tables[0];
        }

    }
}
