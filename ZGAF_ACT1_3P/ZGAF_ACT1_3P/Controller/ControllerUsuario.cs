using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ZGAF_06.Db;
using ZGAF_ACT1_3P.Model;

namespace ZGAF_ACT1_3P.Controller
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
            string query = "SELECT NombreUsuario, ContraseniaUsuario FROM Usuario " +
                "WHERE NombreUsuario = @NombreUsuario AND ContraseniaUsuario = @ContraseniaUsuario;";

            cmd = new SqlCommand(query, connection);

            //Se crean los parámetros 
            cmd.Parameters.Add("@NombreUsuario", SqlDbType.VarChar);
            cmd.Parameters.Add("@ContraseniaUsuario", SqlDbType.VarChar);

            //Inserción de datos a los parámetros
            cmd.Parameters["@NombreUsuario"].Value = usuario.NombreUsuario;
            cmd.Parameters["@ContraseniaUsuario"].Value = usuario.ContraseniaUsuario;

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if(dt.Rows.Count == 1)
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
            string query = "INSERT INTO Usuario (NombreUsuario, ContraseniaUsuario)" +
                             "VALUES(@NombreUsuario, @ContraseniaUsuario)";

            cmd = new SqlCommand(query, connection);

            //Se crean los parámetros 
            cmd.Parameters.Add("@NombreUsuario", SqlDbType.VarChar);
            cmd.Parameters.Add("@ContraseniaUsuario", SqlDbType.VarChar);

            //Inserción de datos a los parámetros
            cmd.Parameters["@NombreUsuario"].Value = usuario.NombreUsuario;
            cmd.Parameters["@ContraseniaUsuario"].Value = usuario.ContraseniaUsuario;

            //Verificación de Query 
            int res = cmd.ExecuteNonQuery();
            if (res > 0)
            {
                MessageBox.Show("Registro Exitoso", "Etzito");
            }
            else
            {
                MessageBox.Show("Explotóooo", "BUUUUM");
            }
            sqlServerConnection.Cerrar();
        }
    }
}
