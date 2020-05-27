using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZGAF_06.Db;
using ZGAF_ACT2_3P.Model;
using System.Windows;

namespace ZGAF_ACT2_3P.Controller
{
    public class ControllerMedicamento
    {
        SqlServerConnection sqlServerConnection = null;
        public List<Medicamento> GetMedicamentos()
        {
            List<Medicamento> medicamentos = new List<Medicamento>();
            sqlServerConnection = new SqlServerConnection();
            SqlConnection sqlConnection = sqlServerConnection.Abrir();
            string _select = "SELECT * FROM Medicamento;";
            SqlCommand sqlCommand = new SqlCommand(_select, sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            Medicamento m = null;
            while (sqlDataReader.Read())
            {
                m = new Medicamento();
                m.IdMedicamento = sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("IdMedicamento"));
                m.NombreGeneral = sqlDataReader.GetString(sqlDataReader.GetOrdinal("NombreGeneral"));
                m.FormaFarmaceutica = sqlDataReader.GetString(sqlDataReader.GetOrdinal("FormaFarmaceutica"));
                m.Concentracion = sqlDataReader.GetString(sqlDataReader.GetOrdinal("Concentracion"));
                m.PricipalIndicacion = sqlDataReader.GetString(sqlDataReader.GetOrdinal("PricipalIndicacion"));
                m.PrecioUnidad = sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("PrecioUnidad"));
                m.Activo = sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("Activo"));
                m.UnidadesEnvase = sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("UnidadesEnvase"));
                m.UnidadMedida = sqlDataReader.GetString(sqlDataReader.GetOrdinal("UnidadMedida"));
                m.Categoria = sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("Categoria"));

                medicamentos.Add(m);
            }
            sqlServerConnection.Cerrar();
            return medicamentos;
        }

        public void InsertMedicamento(Medicamento medicamento)
        {
            sqlServerConnection = new SqlServerConnection();
            SqlCommand cmd = null;
            SqlConnection connection = sqlServerConnection.Abrir();

            //----------------------------INSERCION DATOS PROPIOS DE USUARIO-----------------------------------------
            string query = "INSERT INTO Medicamento  (NombreGeneral, FormaFarmaceutica, Concentracion, PricipalIndicacion, PrecioUnidad, Activo, UnidadesEnvase, UnidadMedida, Categoria)" +
                             "VALUES (@NombreGeneral, @FormaFarmaceutica, @Concentracion, @PricipalIndicacion, @PrecioUnidad, @Activo, @UnidadesEnvase, @UnidadMedida, @Categoria);";

            cmd = new SqlCommand(query, connection);

            //Se crean los parámetros 
            cmd.Parameters.Add("@NombreGeneral", SqlDbType.VarChar);
            cmd.Parameters.Add("@FormaFarmaceutica", SqlDbType.VarChar);
            cmd.Parameters.Add("@Concentracion", SqlDbType.VarChar);
            cmd.Parameters.Add("@PricipalIndicacion", SqlDbType.VarChar);
            cmd.Parameters.Add("@PrecioUnidad", SqlDbType.Int);
            cmd.Parameters.Add("@Activo", SqlDbType.Int);
            cmd.Parameters.Add("@UnidadesEnvase", SqlDbType.Int);
            cmd.Parameters.Add("@UnidadMedida", SqlDbType.VarChar);
            cmd.Parameters.Add("@Categoria", SqlDbType.Int);

            //Inserción de datos a los parámetros
            cmd.Parameters["@NombreGeneral"].Value = medicamento.NombreGeneral;
            cmd.Parameters["@FormaFarmaceutica"].Value = medicamento.FormaFarmaceutica;
            cmd.Parameters["@Concentracion"].Value = medicamento.Concentracion;
            cmd.Parameters["@PricipalIndicacion"].Value = medicamento.PricipalIndicacion;
            cmd.Parameters["@PrecioUnidad"].Value = medicamento.PrecioUnidad;
            cmd.Parameters["@Activo"].Value = medicamento.Activo;
            cmd.Parameters["@UnidadesEnvase"].Value = medicamento.UnidadesEnvase;
            cmd.Parameters["@UnidadMedida"].Value = medicamento.UnidadMedida;
            cmd.Parameters["@Categoria"].Value = medicamento.Categoria;

            //Verificación de Query 
            int res = cmd.ExecuteNonQuery();
            if (res > 0)
            {
                MessageBox.Show("Inserción Exitosa", "Carita Feliz");
            }
            else
            {
                MessageBox.Show("Explotóooo", "BUUUUM");
            }
            sqlServerConnection.Cerrar();
        }


        public void UpdateMedicamento(Medicamento medicamento)
        {
            sqlServerConnection = new SqlServerConnection();
            SqlCommand cmd = null;
            SqlConnection connection = sqlServerConnection.Abrir();

            //----------------------------INSERCION DATOS PROPIOS DE USUARIO-----------------------------------------
            string query = "UPDATE Medicamento SET NombreGeneral = @NombreGeneral, FormaFarmaceutica = @FormaFarmaceutica," +
                "Concentracion = @Concentracion, PricipalIndicacion = @PricipalIndicacion, PrecioUnidad = @PrecioUnidad," +
                "Activo = @Activo, UnidadesEnvase = @UnidadesEnvase, UnidadMedida = @UnidadMedida " +
                "WHERE IdMedicamento = @IdMedicamento;";

            cmd = new SqlCommand(query, connection);

            //Se crean los parámetros 
            cmd.Parameters.Add("@NombreGeneral", SqlDbType.VarChar);
            cmd.Parameters.Add("@FormaFarmaceutica", SqlDbType.VarChar);
            cmd.Parameters.Add("@Concentracion", SqlDbType.VarChar);
            cmd.Parameters.Add("@PricipalIndicacion", SqlDbType.VarChar);
            cmd.Parameters.Add("@PrecioUnidad", SqlDbType.Int);
            cmd.Parameters.Add("@Activo", SqlDbType.Int);
            cmd.Parameters.Add("@UnidadesEnvase", SqlDbType.Int);
            cmd.Parameters.Add("@UnidadMedida", SqlDbType.VarChar);
            cmd.Parameters.Add("@Categoria", SqlDbType.Int);
            cmd.Parameters.Add("@IdMedicamento", SqlDbType.Int);

            //Inserción de datos a los parámetros
            cmd.Parameters["@NombreGeneral"].Value = medicamento.NombreGeneral;
            cmd.Parameters["@FormaFarmaceutica"].Value = medicamento.FormaFarmaceutica;
            cmd.Parameters["@Concentracion"].Value = medicamento.Concentracion;
            cmd.Parameters["@PricipalIndicacion"].Value = medicamento.PricipalIndicacion;
            cmd.Parameters["@PrecioUnidad"].Value = medicamento.PrecioUnidad;
            cmd.Parameters["@Activo"].Value = medicamento.Activo;
            cmd.Parameters["@UnidadesEnvase"].Value = medicamento.UnidadesEnvase;
            cmd.Parameters["@UnidadMedida"].Value = medicamento.UnidadMedida;
            cmd.Parameters["@Categoria"].Value = medicamento.Categoria;
            cmd.Parameters["@IdMedicamento"].Value = medicamento.IdMedicamento;

            //Verificación de Query 
            int res = cmd.ExecuteNonQuery();
            if (res > 0)
            {
                MessageBox.Show("Actualización Exitosa", "Carita Feliz");
            }
            else
            {
                MessageBox.Show("Explotóooo", "BUUUUM");
            }
            sqlServerConnection.Cerrar();
        }


        public void DeleteMedicamento(Medicamento medicamento)
        {
            sqlServerConnection = new SqlServerConnection();
            SqlCommand cmd = null;
            SqlConnection connection = sqlServerConnection.Abrir();

            //----------------------------INSERCION DATOS PROPIOS DE USUARIO-----------------------------------------
            string query = "DELETE FROM Medicamento " +
                "WHERE IdMedicamento = @IdMedicamento;";

            cmd = new SqlCommand(query, connection);

            //Se crean los parámetros 
            cmd.Parameters.Add("@IdMedicamento", SqlDbType.Int);

            //Inserción de datos a los parámetros
            cmd.Parameters["@IdMedicamento"].Value = medicamento.IdMedicamento;

            //Verificación de Query 
            int res = cmd.ExecuteNonQuery();
            if (res > 0)
            {
                MessageBox.Show(medicamento.NombreGeneral + " ha sido eliminado", "Carita Triste");
            }
            else
            {
                MessageBox.Show("Explotóooo", "BUUUUM");
            }
            sqlServerConnection.Cerrar();
        }
    }
}
