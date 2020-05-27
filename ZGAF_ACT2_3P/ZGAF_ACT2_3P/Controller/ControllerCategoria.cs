using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ZGAF_06.Db;
using ZGAF_ACT2_3P.Model;

namespace ZGAF_ACT2_3P.Controller
{
    public class ControllerCategoria
    {
        SqlServerConnection sqlServerConnection = null;
        public List<Categoria> GetCategorias()
        {
            List<Categoria> categorias = new List<Categoria>();
            sqlServerConnection = new SqlServerConnection();
            SqlConnection sqlConnection = sqlServerConnection.Abrir();
            string _select = "SELECT * FROM Categoria;";
            SqlCommand sqlCommand = new SqlCommand(_select, sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            Categoria c = null;
            while (sqlDataReader.Read())
            {
                c = new Categoria();
                c.IdCategoria = sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("IdCategoria"));
                c.Proveedor = sqlDataReader.GetString(sqlDataReader.GetOrdinal("Proveedor"));
                categorias.Add(c);
            }
            sqlServerConnection.Cerrar();
            return categorias;
        }

        public void InsertCategoria(Categoria categoria)
        {
            sqlServerConnection = new SqlServerConnection();
            SqlCommand cmd = null;
            SqlConnection connection = sqlServerConnection.Abrir();

            //----------------------------INSERCION DATOS PROPIOS DE USUARIO-----------------------------------------
            string query = "INSERT INTO Categoria (Proveedor)" +
                             "VALUES (@Proveedor);";

            cmd = new SqlCommand(query, connection);

            //Se crean los parámetros 
            cmd.Parameters.Add("@Proveedor", SqlDbType.VarChar);


            //Inserción de datos a los parámetros
            cmd.Parameters["@Proveedor"].Value = categoria.Proveedor;
            //Verificación de Query 
            int res = cmd.ExecuteNonQuery();
            if (res > 0)
            {
                MessageBox.Show("Inserción Exitosa", "Carita Feliz");
            }
            else
            {
                MessageBox.Show("Explotóooo", "BUUUUM");
            }
            sqlServerConnection.Cerrar();
        }

        public void UpdateCategoria(Categoria categoria)
        {
            sqlServerConnection = new SqlServerConnection();
            SqlCommand cmd = null;
            SqlConnection connection = sqlServerConnection.Abrir();

            //----------------------------INSERCION DATOS PROPIOS DE USUARIO-----------------------------------------
            string query = "UPDATE Categoria " +
                "SET Proveedor = @Proveedor " +
                "WHERE IdCategoria = @IdCategoria;";

            cmd = new SqlCommand(query, connection);

            //Se crean los parámetros 
            cmd.Parameters.Add("@Proveedor", SqlDbType.VarChar);
            cmd.Parameters.Add("@IdCategoria", SqlDbType.Int);


            //Inserción de datos a los parámetros
            cmd.Parameters["@Proveedor"].Value = categoria.Proveedor;
            cmd.Parameters["@IdCategoria"].Value = categoria.IdCategoria;

            //Verificación de Query 
            int res = cmd.ExecuteNonQuery();
            if (res > 0)
            {
                MessageBox.Show("Actualización Exitosa", "Carita Feliz");
            }
            else
            {
                MessageBox.Show("Explotóooo", "BUUUUM");
            }
            sqlServerConnection.Cerrar();
        }

        public void DeleteCategoria(Categoria categoria)
        {
            sqlServerConnection = new SqlServerConnection();
            SqlCommand cmd = null;
            SqlConnection connection = sqlServerConnection.Abrir();

            //----------------------------INSERCION DATOS PROPIOS DE USUARIO-----------------------------------------
            string query = "DELETE FROM Categoria " +
                "WHERE IdCategoria = @IdCategoria;";

            cmd = new SqlCommand(query, connection);

            //Se crean los parámetros 
            cmd.Parameters.Add("@IdCategoria", SqlDbType.Int);


            //Inserción de datos a los parámetros
            cmd.Parameters["@IdCategoria"].Value = categoria.IdCategoria;

            //Verificación de Query 
            int res = cmd.ExecuteNonQuery();
            if (res > 0)
            {
                MessageBox.Show(categoria.Proveedor + " ha sido eliminado", "Carita Triste");
            }
            else
            {
                MessageBox.Show("Explotóooo", "BUUUUM");
            }
            sqlServerConnection.Cerrar();
        }
    }
}
