using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace proyecto_POO_BD.Properties
{
    public class CheckAdmin : accessSQL
    {
        public CheckAdmin() : base()
        {
        }

        public bool Login(string User, string Pass)
        {
            using (var connection = getConnection())
            {
                connection.Open();
                using(var command = new SqlCommand())
                {
                    command.Parameters.AddWithValue("@vUser", User);
                    command.Parameters.AddWithValue("@vPass", Pass);
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM ADMINISTRADOR WHERE Usuario = @vUser AND Contraseña = @vPass";
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        return true;
                    }
                    else
                        return false;
                }
            }
        }
    }
}
