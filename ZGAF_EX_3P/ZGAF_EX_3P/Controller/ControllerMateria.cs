using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ZGAF_06.Db;
using ZGAF_EX_3P.Model;

namespace ZGAF_EX_3P.Controller
{
    public class ControllerMateria
    {
        SqlServerConnection sqlServerConnection = null;

        public List<Materia> GetMaterias()
        {
            List<Materia> materias = new List<Materia>();
            sqlServerConnection = new SqlServerConnection();
            SqlConnection sqlConnection = sqlServerConnection.Abrir();
            string _select = "SELECT * FROM vw_MAT_CAR2;";
            SqlCommand sqlCommand = new SqlCommand(_select, sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            Materia materia = null;
            while (sqlDataReader.Read())
            {
                materia = new Materia();

                materia.Folio = sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("Folio"));
                materia.Nombre = sqlDataReader.GetString(sqlDataReader.GetOrdinal("NombreMateria"));
                materia.Descripcion = sqlDataReader.GetString(sqlDataReader.GetOrdinal("Descripcion"));
                materia.HorasSemana = sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("HorasSemanales"));
                materia.NumSemestre = sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("Semestre"));
                materia.Nombre_ = sqlDataReader.GetString(sqlDataReader.GetOrdinal("NombreCarrera"));
                materia.RegistroSep = sqlDataReader.GetString(sqlDataReader.GetOrdinal("RegistroSEP"));
                materias.Add(materia);
            }
            sqlServerConnection.Cerrar();
            return materias;
        }

        public void UpdateMateria(Materia materia)
        {
            SqlConnection connection = sqlServerConnection.Abrir();
            string sql = "EXECUTE sp_EditMateria" +
                " " + materia.Folio + "," +
                "'" + materia.Nombre + "'," +
                "'" + materia.Descripcion + "'," +
                "" + materia.HorasSemana + "," +
                "" + materia.NumSemestre + "," +
                "'" + materia.Nombre_ + "'," +
                "'" + materia.RegistroSep + "'";
            SqlCommand command = new SqlCommand(sql, connection);
            int r = command.ExecuteNonQuery();
            if (r <= 0)
            {
                MessageBox.Show("Error de Insercion");
            }

            connection.Close();
            sqlServerConnection.Cerrar();
        }
    }
}
