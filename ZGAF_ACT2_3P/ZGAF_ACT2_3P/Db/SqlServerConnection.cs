using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ZGAF_06.Db
{
    public class SqlServerConnection
    {
        //Se crea una variable de tipo SqlConnection
        //Insertar "using System.Data.SqlClient;" para que funcione.
        public SqlConnection Connection { get; set; }

        public SqlConnection Abrir()
        {
            string connectionString = "DATA SOURCE = FABRICIO\\SQLEXPRESS;" + "INITIAL CATALOG = dbfarmacia;" + "INTEGRATED SECURITY = YES;";
            try
            {
                Connection = new SqlConnection(connectionString);
                Connection.Open();
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
