using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace proyecto_POO_BD.Properties
{
    
    public interface SQLReaderWriter
    {
        DataTable consult(string a, string b);
    }

    public class EventSQL : accessSQL, SQLReaderWriter
    {
        public EventSQL() : base()
        {
        }
        DataTable SQLReaderWriter.consult(string word, string colunm)
        {
            DataTable dt = new DataTable();

            if (colunm == "Nombre de Evento")
                colunm = "Titulo";

            using (var connection = getConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Parameters.AddWithValue("@vWord", word);
                    command.Parameters.AddWithValue("@vColunm", colunm);
                    command.Connection = connection;
                    command.CommandText = $"SELECT EVENTO.Id, EVENTO.Titulo, EVENTO.FechaHora_Inicio, EVENTO.FechaHora_Fin, EVENTO.CantidadParticipantes, AREA.Nombre AS 'Area' FROM EVENTO INNER JOIN AREA ON EVENTO.Id_Area = AREA.Id WHERE Titulo LIKE '{word}%'";
                    command.CommandType = CommandType.Text;
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = command;
                    adapter.Fill(dt);
                }
            }
            return dt;
        }
    }
}
