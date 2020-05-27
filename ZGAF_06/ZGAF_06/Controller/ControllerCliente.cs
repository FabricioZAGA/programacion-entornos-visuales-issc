using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ZGAF_06.Db;
using ZGAF_06.Model;

namespace ZGAF_06.Controller
{
    public class ControllerCliente
    {
        SqlServerConnection sqlServerConnection = null;

        public void InsertCliente(Cliente cliente)
        {
            sqlServerConnection = new SqlServerConnection();
            SqlCommand cmd = null;
            SqlConnection connection = sqlServerConnection.Abrir();

            //----------------------------INSERCION DATOS PROPIOS DE CLIENTE-----------------------------------------
            string query = "INSERT INTO Cliente(Nombre, ApPaterno, ApMaterno, Email, IdUsuario) " +
                             "VALUES(@Nombre, @ApPaterno, @ApMaterno, @Email,  @IdUsuario)";

            cmd = new SqlCommand(query, connection);

            //Se crean los parámetros para cliente
            cmd.Parameters.Add("@Nombre", SqlDbType.VarChar); //Parámetro para nombre cliente
            cmd.Parameters.Add("@ApPaterno", SqlDbType.VarChar); //Parámetro para apellido paterno
            cmd.Parameters.Add("@ApMaterno", SqlDbType.VarChar); //Parámetro para apellido materno
            cmd.Parameters.Add("@Email", SqlDbType.VarChar); //Parámetro para email
            cmd.Parameters.Add("@IdUsuario", SqlDbType.Int); //Parámetro para id de usuario


            //Inserción de datos a los parámetros
            cmd.Parameters["@Nombre"].Value = cliente.Nombre;
            cmd.Parameters["@ApPaterno"].Value = cliente.ApPaterno;
            cmd.Parameters["@ApMaterno"].Value = cliente.ApMaterno;
            cmd.Parameters["@Email"].Value = cliente.Email;
            cmd.Parameters["@IdUsuario"].Value = 1;


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














        public List<Cliente> Clientes = new List<Cliente>();
        public void AgregarCliente(Cliente cliente)
        {
            Clientes.Add(cliente);
        }

        public List<Cliente> GetAll()
        {
            return Clientes;
        }
        public List<Cliente> FindApPaterno(string apPaterno)
        {
            List<Cliente> encontrados = new List<Cliente>();
            foreach (Cliente client in Clientes)
            {
                if (client.ApPaterno.Equals(apPaterno) == true)
                {
                    encontrados.Add(client);
                }
            }
            return encontrados;
        }
    }
}
