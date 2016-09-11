using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_Calendar.Data.Classes
{
    public class SqlExecuteMethods
    {
        private SqlConnection conn;


        public SqlDataReader ExecuteReader(CommandType type, string CommandText, SqlParameter[] pars)
        {
            SqlCommand comm = new SqlCommand
            {
                CommandType = type,
                CommandText = CommandText,
                Connection = conn
            };

            comm.Parameters.AddRange(pars);
            return comm.ExecuteReader();

        }

        public object ExecuteScalar(CommandType type, string CommandText, SqlParameter[] pars)
        {
            SqlCommand comm = new SqlCommand
            {
                CommandType = type,
                CommandText = CommandText,
                Connection = conn
            };
            comm.Parameters.AddRange(pars);
            return comm.ExecuteScalar();
        }
    }
}
