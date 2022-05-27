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
            this.connection = "Data Source=25.67.193.151,1433;DataBase=BINAES;User ID=BINAESdb;Password=serverdb";
        }

        protected SqlConnection getConnection()
        {
            return new SqlConnection(connection);
        }
    }
}
