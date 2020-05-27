using Parcial2.Model;
using Parcial2.Controller;
using Parcial2.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows;

namespace Parcial2.Controller
{
    public class ControllerProducto
    {

        SqlServerConnection sqlServerConnection = null;

        public void InsertProducto(Producto producto)
        {
            sqlServerConnection = new SqlServerConnection();
            SqlCommand cmd = null;
            SqlConnection connection = sqlServerConnection.Abrir();

            //----------------------------INSERCION DATOS PROPIOS DEL PRODUCTO-----------------------------------------
            string query = "INSERT INTO Producto VALUES(@Nombre, @Precio, @Cantidad)";

            cmd = new SqlCommand(query, connection);

            //Se crean los parámetros 
            cmd.Parameters.Add("@Nombre", SqlDbType.VarChar);
            cmd.Parameters.Add("@Precio", SqlDbType.Int);
            cmd.Parameters.Add("@Cantidad", SqlDbType.Int);


            //Inserción de datos a los parámetros
            cmd.Parameters["@Nombre"].Value = producto.Nombre;
            cmd.Parameters["@Precio"].Value = producto.Precio;
            cmd.Parameters["@Cantidad"].Value = producto.Cantidad;


            //Verificación de Query 
            int res = cmd.ExecuteNonQuery();
            if (res > 0)
            {
                MessageBox.Show("ChiCHEÑOOOOL", "Etzito");
            }
            else
            {
                MessageBox.Show("Explotóooo", "BUUUUM");
            }
            sqlServerConnection.Cerrar();
        }

        public List<Producto> MostrarProducto()
        {
            List<Producto> productos = new List<Producto>();
            Producto p_1 = new Producto("Computadora Acer",23000,2);
            Producto p_2 = new Producto("Computadora Lenovo", 35000, 3);
            Producto p_3= new Producto("Servidor Lenovo", 85000, 1);
            Producto p_4 = new Producto("Monitor LG", 15000, 3);
            Producto p_5 = new Producto("Dron Phanton", 42000, 5);
            productos.Add(p_1);
            productos.Add(p_2);
            productos.Add(p_3);
            productos.Add(p_4);
            productos.Add(p_5);
            return productos;
        }

    }
}
