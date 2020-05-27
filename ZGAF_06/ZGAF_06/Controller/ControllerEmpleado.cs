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

    public class ControllerEmpleado
    {
        SqlServerConnection sqlServerConnection = null;

        public void InsertEmpleado(Empleado empleado)
        {
            sqlServerConnection = new SqlServerConnection();
            SqlCommand cmd = null;
            SqlConnection connection = sqlServerConnection.Abrir();

            //----------------------------INSERCION DATOS PROPIOS DE EMPLEADO-----------------------------------------
            string query = "INSERT INTO Empleado(Nombre, ApPaterno, ApMaterno, FechaIngreso, IdUsuario) " +
                             "VALUES(@Nombre, @ApPaterno, @ApMaterno, @FechaIngreso,  @IdUsuario)";

            cmd = new SqlCommand(query, connection);

            //Se crean los parámetros para cliente
            cmd.Parameters.Add("@Nombre", SqlDbType.VarChar); //Parámetro para nombre cliente
            cmd.Parameters.Add("@ApPaterno", SqlDbType.VarChar); //Parámetro para apellido paterno
            cmd.Parameters.Add("@ApMaterno", SqlDbType.VarChar); //Parámetro para apellido materno
            cmd.Parameters.Add("@FechaIngreso", SqlDbType.DateTime); //Parámetro para email
            cmd.Parameters.Add("@IdUsuario", SqlDbType.Int); //Parámetro para id de usuario


            //Inserción de datos a los parámetros
            cmd.Parameters["@Nombre"].Value = empleado.Nombre;
            cmd.Parameters["@ApPaterno"].Value = empleado.ApPaterno;
            cmd.Parameters["@ApMaterno"].Value = empleado.ApMaterno;
            cmd.Parameters["@FechaIngreso"].Value = empleado.FechaIngreso;
            cmd.Parameters["@IdUsuario"].Value = 4;


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
















        public List<Empleado> Empleados = new List<Empleado>();
        public void AgregarEmpleado(Empleado empleado)
        {
            Empleados.Add(empleado);
        }

        public List<Empleado> GetAll()
        {
            return Empleados;
        }

        public List<Empleado> FindApPaterno(string apPaterno)
        {
            List<Empleado> encontrados = new List<Empleado>();
            foreach (Empleado emp in Empleados)
            {
                if (emp.ApPaterno.Equals(apPaterno) == true)
                {
                    encontrados.Add(emp);
                }
            }
            return encontrados;
        }
    }
}
