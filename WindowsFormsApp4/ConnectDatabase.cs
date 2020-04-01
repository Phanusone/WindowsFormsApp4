using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
namespace WindowsFormsApp4
{
    class ConnectDatabase
    {
        public  MySqlConnection conn = new MySqlConnection();
        public  MySqlConnection getConnect()
    
        {
            
                string strcon = @"server=localhost;
                                             User ID= root;
                                             password= ;
                                             database= bmstore;";
              
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                conn.ConnectionString = strcon;
                conn.Open();
                return conn;
           

        }
        public  MySqlConnection getCloseConnect()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            return conn;
        }
    }
}
