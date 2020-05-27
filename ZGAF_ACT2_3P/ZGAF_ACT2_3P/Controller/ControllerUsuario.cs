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
    public class ControllerUsuario
    {
        SqlServerConnection sqlServerConnection = null;
        public bool LogIngUsuario(Usuario usuario)
        {
            sqlServerConnection = new SqlServerConnection();
            SqlCommand cmd = null;
            SqlConnection connection = sqlServerConnection.Abrir();

            //----------------------------BUSQUEDA DE USUARIO-----------------------------------------
            string query = "SELECT Nombre, Contrasennia FROM Usuario " +
                "WHERE Nombre = @Nombre AND Contrasennia = @Contrasennia;";

            cmd = new SqlCommand(query, connection);

            //Se crean los parámetros 
            cmd.Parameters.Add("@Nombre", SqlDbType.VarChar);
            cmd.Parameters.Add("@Contrasennia", SqlDbType.VarChar);

            //Inserción de datos a los parámetros
            cmd.Parameters["@Nombre"].Value = usuario.Nombre;
            cmd.Parameters["@Contrasennia"].Value = usuario.Contrasenia;

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                sqlServerConnection.Cerrar();
                MessageBox.Show("ChiCHEÑOOOOL", "Etzito");
                return true;
            }
            else
            {
                sqlServerConnection.Cerrar();
                MessageBox.Show("Usuario y/o Contraseña Incorrectos", "Error");
                return false;
            }
        }

        public void InsertUsuario(Usuario usuario)
        {
            sqlServerConnection = new SqlServerConnection();
            SqlCommand cmd = null;
            SqlConnection connection = sqlServerConnection.Abrir();

            //----------------------------INSERCION DATOS PROPIOS DE USUARIO-----------------------------------------
            string query = "INSERT INTO Usuario (Nombre, Contrasennia, Rol)" +
                             "VALUES (@Nombre, @Contrasennia, @Rol);";

            cmd = new SqlCommand(query, connection);

            //Se crean los parámetros 
            cmd.Parameters.Add("@Nombre", SqlDbType.VarChar);
            cmd.Parameters.Add("@Contrasennia", SqlDbType.VarChar);
            cmd.Parameters.Add("@Rol", SqlDbType.VarChar);

            //Inserción de datos a los parámetros
            cmd.Parameters["@Nombre"].Value = usuario.Nombre;
            cmd.Parameters["@Contrasennia"].Value = usuario.Contrasenia;
            cmd.Parameters["@Rol"].Value = usuario.Rol;
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

        public void UpdateUsuario(Usuario usuario)
        {
            sqlServerConnection = new SqlServerConnection();
            SqlCommand cmd = null;
            SqlConnection connection = sqlServerConnection.Abrir();

            //----------------------------INSERCION DATOS PROPIOS DE USUARIO-----------------------------------------
            string query = "UPDATE Usuario " +
                "SET Nombre = @Nombre,  Contrasennia = @Contrasennia, Rol = @Rol " +
                "WHERE IdUsuario = @IdUsuario;";

            cmd = new SqlCommand(query, connection);
            //Se crean los parámetros 
            cmd.Parameters.Add("@Nombre", SqlDbType.VarChar);
            cmd.Parameters.Add("@Contrasennia", SqlDbType.VarChar);
            cmd.Parameters.Add("@Rol", SqlDbType.VarChar);
            cmd.Parameters.Add("@IdUsuario", SqlDbType.Int);

            //Inserción de datos a los parámetros
            cmd.Parameters["@Nombre"].Value = usuario.Nombre;
            cmd.Parameters["@Contrasennia"].Value = usuario.Contrasenia;
            cmd.Parameters["@Rol"].Value = usuario.Rol;
            cmd.Parameters["@IdUsuario"].Value = usuario.IdUsuario;

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

        public List<Usuario> GetUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();
            sqlServerConnection = new SqlServerConnection();
            SqlConnection sqlConnection = sqlServerConnection.Abrir();
            string _select = "SELECT * FROM Usuario;";
            SqlCommand sqlCommand = new SqlCommand(_select, sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            Usuario usuario = null;
            while (sqlDataReader.Read())
            {
                usuario = new Usuario();
                usuario.IdUsuario = sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("IdUsuario"));
                usuario.Nombre = sqlDataReader.GetString(sqlDataReader.GetOrdinal("Nombre"));
                usuario.Contrasenia = sqlDataReader.GetString(sqlDataReader.GetOrdinal("Contrasennia"));
                usuario.Rol = sqlDataReader.GetString(sqlDataReader.GetOrdinal("Rol"));
                usuarios.Add(usuario);
            }
            sqlServerConnection.Cerrar();
            return usuarios;
        }


        public void DeleteUsuario(Usuario usuario)
        {
            sqlServerConnection = new SqlServerConnection();
            SqlCommand cmd = null;
            SqlConnection connection = sqlServerConnection.Abrir();

            //----------------------------INSERCION DATOS PROPIOS DE USUARIO-----------------------------------------
            string query = "DELETE FROM Usuario " +
                "WHERE IdUsuario = @IdUsuario;";

            cmd = new SqlCommand(query, connection);
            //Se crean los parámetros 
            cmd.Parameters.Add("@IdUsuario", SqlDbType.Int);

            //Inserción de datos a los parámetros
            cmd.Parameters["@IdUsuario"].Value = usuario.IdUsuario;

            //Verificación de Query 
            int res = cmd.ExecuteNonQuery();
            if (res > 0)
            {
                MessageBox.Show(usuario.Nombre + " ha sido eliminado", "Carita Triste");
            }
            else
            {
                MessageBox.Show("Explotóooo", "BUUUUM");
            }
            sqlServerConnection.Cerrar();
        }
    }
}
