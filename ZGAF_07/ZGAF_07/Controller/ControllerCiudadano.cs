using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ZGAF_07.Db;
using ZGAF_07.Model;

namespace ZGAF_07.Controller
{
    public class ControllerCiudadano
    {
        SqlServerConnection sqlServerConnection = null;

        public void InsertCiudadano(Ciudadano ciudadano)
        {
            sqlServerConnection = new SqlServerConnection();
            SqlCommand cmd = null;
            SqlConnection connection = sqlServerConnection.Abrir();

            //----------------------------INSERCION DATOS PROPIOS DE CLIENTE-----------------------------------------
            string query = "INSERT INTO Ciudadano(Nombre, ApellidoPaterno, ApellidoMaterno, Sexo, Colonia, CodigoPostal, FechaIngreso)" +
                             "VALUES(@Nombre, @ApellidoPaterno, @ApellidoMaterno, @Sexo,  @Colonia, @CodigoPostal, @FechaIngreso)";

            cmd = new SqlCommand(query, connection);

            //Se crean los parámetros 
            cmd.Parameters.Add("@Nombre", SqlDbType.VarChar);
            cmd.Parameters.Add("@ApellidoPaterno", SqlDbType.VarChar);
            cmd.Parameters.Add("@ApellidoMaterno", SqlDbType.VarChar);
            cmd.Parameters.Add("@Sexo", SqlDbType.Int);
            cmd.Parameters.Add("@Colonia", SqlDbType.Int);
            cmd.Parameters.Add("@CodigoPostal", SqlDbType.Int);
            cmd.Parameters.Add("@FechaIngreso", SqlDbType.DateTime);



            //Inserción de datos a los parámetros
            cmd.Parameters["@Nombre"].Value = ciudadano.Nombre;
            cmd.Parameters["@ApellidoPaterno"].Value = ciudadano.ApellidoPaterno;
            cmd.Parameters["@ApellidoMaterno"].Value = ciudadano.ApellidoMaterno;
            cmd.Parameters["@Sexo"].Value = ciudadano.Sexo;
            cmd.Parameters["@Colonia"].Value = ciudadano.Colonia;
            cmd.Parameters["@CodigoPostal"].Value = ciudadano.CodigoPostal;
            cmd.Parameters["@FechaIngreso"].Value = ciudadano.FechaIngreso;


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
    }
}
