using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConnectionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string connstring = @"Data Source=SC-201510032109\SQLEXPRESS;Initial Catalog=Students;Integrated Security=True;Pooling=False";
            SqlConnection conn = new SqlConnection(connstring);
            try
            {
                conn.Open();
                Console.WriteLine("Successfully Connected");
            }
            catch(SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                conn.Close();
                Console.WriteLine("Connection closed");
            }
        }
    }
}
