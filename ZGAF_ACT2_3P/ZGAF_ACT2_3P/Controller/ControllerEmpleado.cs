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
    public class ControllerEmpleado
    {
        SqlServerConnection sqlServerConnection = null;

        public List<Empleado> GetEmpleados()
        {
            List<Empleado> empleados = new List<Empleado>();
            sqlServerConnection = new SqlServerConnection();
            SqlConnection sqlConnection = sqlServerConnection.Abrir();
            string _select = "SELECT * FROM Empleado;";
            SqlCommand sqlCommand = new SqlCommand(_select, sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            Empleado e = null;
            while (sqlDataReader.Read())
            {
                e = new Empleado();
                e.IdEmpleado = sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("IdEmpleado"));
                e.Nombre = sqlDataReader.GetString(sqlDataReader.GetOrdinal("Nombre"));
                e.ApePaterno = sqlDataReader.GetString(sqlDataReader.GetOrdinal("ApePaterno"));
                e.ApeMaterno = sqlDataReader.GetString(sqlDataReader.GetOrdinal("ApeMaterno"));
                try
                {
                    e.IdUsuario = sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("IdUsuario"));
                }
                catch
                {

                }
                empleados.Add(e);
            }
            sqlServerConnection.Cerrar();
            return empleados;
        }

        public void InsertEmpleado(Empleado empleado)
        {
            sqlServerConnection = new SqlServerConnection();
            SqlCommand cmd = null;
            SqlConnection connection = sqlServerConnection.Abrir();

            //----------------------------INSERCION DATOS PROPIOS DE USUARIO-----------------------------------------
            string query = "INSERT INTO Empleado (Nombre, ApePaterno, ApeMaterno, IdUsuario)" +
                             "VALUES (@Nombre, @ApePaterno, @ApeMaterno, @IdUsuario);";

            cmd = new SqlCommand(query, connection);

            //Se crean los parámetros 
            cmd.Parameters.Add("@Nombre", SqlDbType.VarChar);
            cmd.Parameters.Add("@ApePaterno", SqlDbType.VarChar);
            cmd.Parameters.Add("@ApeMaterno", SqlDbType.VarChar);
            cmd.Parameters.Add("@IdUsuario", SqlDbType.Int);

            //Inserción de datos a los parámetros
            cmd.Parameters["@Nombre"].Value = empleado.Nombre;
            cmd.Parameters["@ApePaterno"].Value = empleado.ApePaterno;
            cmd.Parameters["@ApeMaterno"].Value = empleado.ApeMaterno;
            cmd.Parameters["@IdUsuario"].Value = empleado.IdUsuario;
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

        public void UpdateEmpleado(Empleado empleado)
        {
            sqlServerConnection = new SqlServerConnection();
            SqlCommand cmd = null;
            SqlConnection connection = sqlServerConnection.Abrir();

            //----------------------------INSERCION DATOS PROPIOS DE USUARIO-----------------------------------------
            string query = "UPDATE Empleado " +
                "SET nombre = @Nombre, ApePaterno = @ApePaterno, ApeMaterno = @ApeMaterno " +
                "WHERE IdEmpleado = @IdEmpleado;";

            cmd = new SqlCommand(query, connection);

            //Se crean los parámetros 
            cmd.Parameters.Add("@Nombre", SqlDbType.VarChar);
            cmd.Parameters.Add("@ApePaterno", SqlDbType.VarChar);
            cmd.Parameters.Add("@ApeMaterno", SqlDbType.VarChar);
            cmd.Parameters.Add("@IdEmpleado", SqlDbType.Int);

            //Inserción de datos a los parámetros
            cmd.Parameters["@Nombre"].Value = empleado.Nombre;
            cmd.Parameters["@ApePaterno"].Value = empleado.ApePaterno;
            cmd.Parameters["@ApeMaterno"].Value = empleado.ApeMaterno;
            cmd.Parameters["@IdEmpleado"].Value = empleado.IdEmpleado;
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

        public void DeleteEmpleado(Empleado empleado)
        {
            sqlServerConnection = new SqlServerConnection();
            SqlCommand cmd = null;
            SqlConnection connection = sqlServerConnection.Abrir();

            //----------------------------INSERCION DATOS PROPIOS DE USUARIO-----------------------------------------
            string query = "DELETE FROM Empleado " +
                "WHERE IdEmpleado = @IdEmpleado;";

            cmd = new SqlCommand(query, connection);

            //Se crean los parámetros 
            cmd.Parameters.Add("@IdEmpleado", SqlDbType.Int);

            //Inserción de datos a los parámetros
            cmd.Parameters["@IdEmpleado"].Value = empleado.IdEmpleado;
            //Verificación de Query 
            int res = cmd.ExecuteNonQuery();
            if (res > 0)
            {
                MessageBox.Show(empleado.Nombre + " ha sido eliminado", "Carita Triste");
            }
            else
            {
                MessageBox.Show("Explotóooo", "BUUUUM");
            }
            sqlServerConnection.Cerrar();
        }
    }
}
