using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class MantenimientoDaoa:SqlConnectiondb
    {

        public DataTable GetMantenimientos(int idequipo, int idMantenimiento)
        {
            DataTable dt = new DataTable();

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var Command = new SqlCommand())
                {
                    Command.Connection = connection;
                    Command.CommandType = CommandType.StoredProcedure;
                    Command.CommandText = "BuscarMantenimiento";
                    Command.Parameters.AddWithValue("@IdEquipo", idequipo);
                    Command.Parameters.AddWithValue("@IdTM", idMantenimiento);
                    SqlDataReader reader = Command.ExecuteReader(CommandBehavior.CloseConnection);

                    if (reader.HasRows)
                    {
                        dt.Load(reader);
                        return dt;
                    }
                    else
                    {
                        return dt = null;
                    }
                }
            }
        }
    }
}
