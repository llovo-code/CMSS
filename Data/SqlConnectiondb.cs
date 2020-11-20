using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;



namespace Data
{
    class SqlConnectiondb
    {
        private readonly string ConnectionString;

        public SqlConnectiondb()
        {

            ConnectionString = "Data Source=localhost;Initial Catalog=Gestor_Mantenimiento;Integrated Security=True";

        }

#pragma warning disable CS1002 // Se esperaba ;
         protect SqlConnection GetConnectiondb() { 
#pragma warning restore CS1002 // Se esperaba ;
}
    }
}
