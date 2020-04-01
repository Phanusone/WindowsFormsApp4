using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
namespace WindowsFormsApp4
{
    class DB
    {
        static MySqlConnection con = new MySqlConnection();
        public static MySqlConnection getConnect()
        {
            string strcon = @"server = localhost; user ID = root; Database = bmstore";

            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.ConnectionString = strcon;
            con.Open();
            return con;
        }
    }
}
