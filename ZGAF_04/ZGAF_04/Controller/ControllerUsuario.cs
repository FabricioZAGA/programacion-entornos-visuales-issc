using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZGAF_04.Db;
using ZGAF_04.Model;
using System.Data.SqlClient;
using System.Data;
using System.Windows;

namespace ZGAF_04.Controller
{
    class ControllerUsuario
    {
        SqlServerConnection sqlServerConnection = null;

        public void InsertUser(Usuario usuario)
        {
            sqlServerConnection = new SqlServerConnection();
            SqlCommand cmd = null;
            SqlConnection connection = sqlServerConnection.Abrir();

            //Los values se escriben con pinche @ alv, porque sino no jala y se hagan parámetros las chingaderas esas
            string query = "INSERT INTO Usuario(NombreUsuario, NombreContrasenia) VALUES(@NombreUsuario, @NombreContrasenia)";

            cmd = new SqlCommand(query, connection);

            //Se pasan las chingaderas estas con las siguientes pendejadas
            cmd.Parameters.Add("@NombreUsuario", SqlDbType.VarChar); //Parámetro para nombre de usuario
            cmd.Parameters.Add("@NombreContrasenia", SqlDbType.VarChar); //Parámetro para contraseña

            //Añadimos valores a las pinches mamadas estas
            cmd.Parameters["@NombreUsuario"].Value = usuario.NombreUsuario;
            cmd.Parameters["@NombreContrasenia"].Value = usuario.NombreContrasenia;

            //Método para que se la inserten a la base de datos
            int res = cmd.ExecuteNonQuery();
            if (res > 0)
            {
                MessageBox.Show("ChiCHEÑOOOOL", "Etzito");
            }
            else
            {
                MessageBox.Show("QuePendejooooo", "BUUUUM");
            }
        }
    }
}
