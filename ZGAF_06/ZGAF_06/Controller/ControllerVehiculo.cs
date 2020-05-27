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
    public class ControllerVehiculo
    {
        SqlServerConnection sqlServerConnection = null;

        public void InsertVehiculo(Vehiculo vehiculo)
        {
            sqlServerConnection = new SqlServerConnection();
            SqlCommand cmd = null;
            SqlConnection connection = sqlServerConnection.Abrir();

            //----------------------------INSERCION DATOS PROPIOS DE EMPLEADO-----------------------------------------
            string query = "INSERT INTO Vehiculo(Tipo, Precio, Version_, NumSerie, Color, CodigoCategoria) " +
                             "VALUES(@Tipo, @Precio, @Version_, @NumSerie,  @Color, @CodigoCategoria)";

            cmd = new SqlCommand(query, connection);

            //Se crean los parámetros para cliente
            cmd.Parameters.Add("@Tipo", SqlDbType.VarChar); 
            cmd.Parameters.Add("@Precio", SqlDbType.Decimal); 
            cmd.Parameters.Add("@Version_", SqlDbType.VarChar); 
            cmd.Parameters.Add("@NumSerie", SqlDbType.VarChar); 
            cmd.Parameters.Add("@Color", SqlDbType.VarChar); 
            cmd.Parameters.Add("@CodigoCategoria", SqlDbType.Int); 


            //Inserción de datos a los parámetros
            cmd.Parameters["@Tipo"].Value = vehiculo.Tipo;
            cmd.Parameters["@Precio"].Value = vehiculo.Precio;
            cmd.Parameters["@Version_"].Value = vehiculo.Version;
            cmd.Parameters["@NumSerie"].Value = vehiculo.NumSerie;
            cmd.Parameters["@Color"].Value = vehiculo.Color;
            cmd.Parameters["@CodigoCategoria"].Value = 1;


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



















        List<Vehiculo> autos = new List<Vehiculo>();
        public void AgregarVehiculo(Vehiculo automovil)
        {
            autos.Add(automovil);
        }
        public List<Vehiculo> GetAll()
        {
            return autos;
        }
        public List<Vehiculo> FindMarca(string marca)
        {
            List<Vehiculo> encontrados = new List<Vehiculo>();
            foreach(Vehiculo car in autos)
            {
                if (car._Categoria.Marca.Equals(marca) == true)
                {
                    encontrados.Add(car);
                }
            }
            return encontrados;
        }
        public List<Vehiculo> FindModelo(string modelo)
        {
            List<Vehiculo> encontrados = new List<Vehiculo>();
            foreach (Vehiculo car in autos)
            {
                if (car._Categoria.Modelo.Equals(modelo) == true)
                {
                    encontrados.Add(car);
                }
            }
            return encontrados;
        }
    }
}
