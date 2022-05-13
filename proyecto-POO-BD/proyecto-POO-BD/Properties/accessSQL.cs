using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace proyecto_POO_BD.Properties
{
    public abstract class accessSQL
    {
        private readonly string connection;
        public accessSQL()
        {
            this.connection = "Data Source=DESKTOP-H6ADMFM;DataBase=BINAES;Integrated Security=True";
        }

        protected SqlConnection getConnection()
        {
            return new SqlConnection(connection);
        }
    }
}
