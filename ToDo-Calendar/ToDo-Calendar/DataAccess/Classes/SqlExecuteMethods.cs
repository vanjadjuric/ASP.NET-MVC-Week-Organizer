using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo_Calendar.Connection;

namespace ToDo_Calendar.Data.Classes
{
    public class SqlExecuteMethods
    {

        SqlConnection _con;

        public SqlExecuteMethods(SqlConnection con)
        {
            _con = con;
        }

        public SqlDataReader ExecuteReader(CommandType type, string CommandText, SqlParameter[] pars)
        {
            SqlCommand comm = new SqlCommand
            {
                CommandType = type,
                CommandText = CommandText,
                Connection = _con
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
                Connection = _con
            };
            comm.Parameters.AddRange(pars);
            return comm.ExecuteScalar();
        }
    }
}
