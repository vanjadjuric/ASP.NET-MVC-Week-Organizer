using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace ToDo_Calendar.Connection
{
    public class ConnectionMenager
    {
        public SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

        public SqlConnection Conn
        {
           get { return con; }
        }

        public void Open()
        {
            if (con.State != System.Data.ConnectionState.Open)
                con.Open();
        }
        public void Close()
        {
            if (con.State != System.Data.ConnectionState.Closed)
                con.Close();
        }


    }
}