using Parcial2.Db;
using Parcial2.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2.Controller
{
    public class ControllerUsuario
    {
        SqlServerConnection sqlServerConnection = null;
        public List<Usuario> GetUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();
            sqlServerConnection = new SqlServerConnection();
            SqlConnection sqlConnection = sqlServerConnection.Abrir();
            string _select = "SELECT * FROM USUARIO;";
            SqlCommand sqlCommand = new SqlCommand(_select, sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            Usuario usuario = null;
            while (sqlDataReader.Read())
            {
                usuario = new Usuario();
                usuario.UserName = sqlDataReader.GetString(sqlDataReader.GetOrdinal("UserName"));
                usuario.Contrasenia = sqlDataReader.GetString(sqlDataReader.GetOrdinal("Contrasenia"));
                usuarios.Add(usuario);
            }
            sqlServerConnection.Cerrar();
            return usuarios;
        }
        
    }
}
