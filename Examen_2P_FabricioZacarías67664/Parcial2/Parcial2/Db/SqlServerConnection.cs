using System;
using System.Data.SqlClient;
using System.Windows;

namespace Parcial2.Db
{
    public class SqlServerConnection
    {
        public SqlConnection Connection { get; set; }

        public SqlConnection Abrir()
        {
            string connectionString = "DATA SOURCE = ZAGA\\SQLEXPRESS;" + "INITIAL CATALOG = ZGAF_EX2P;" + "INTEGRATED SECURITY = YES;";
            try
            {
                Connection = new SqlConnection(connectionString);
                Connection.Open();
                MessageBox.Show("Conexión Exitosa", "Étzito");
                return Connection;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "", "Error");
                return null;
            }
        }

        public void Cerrar()
        {
            Connection.Close();
        }
    }
}
