using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ZGAF_04.Db
{
    class SqlServerConnection
    {
        //Se crea una variable de tipo SqlConnection
        //Insertar "using System.Data.SqlClient;" para que funcione.
        public SqlConnection Connection { get; set; }

        public SqlConnection Abrir()
        {
            string connectionString = "DATA SOURCE = ZAGA\\SQLEXPRESS;" + "INITIAL CATALOG = JugueteriaMahuiltia;" + "INTEGRATED SECURITY = YES;";
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
