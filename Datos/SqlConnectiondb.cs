using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class SqlConnectiondb
    {

        private readonly string ConnectionString;

        public SqlConnectiondb()
        {
            ConnectionString = "Data Source=localhost;Initial Catalog=Gestor_Mantenimiento;Integrated Security=True";
        }

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}
