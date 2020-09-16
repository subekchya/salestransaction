using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Newtonsoft.Json;

namespace SalesTransaction.DataAcess
{
    public class DataAccessHelper
    {
        //creating previelege details
        public SqlConnection connection = new SqlConnection(
                "Data Source=10.6.0.246;" +
                 "Initial Catalog=Subekchya;" +
                  "User ID=intern;" +
                    "Password=intern001;" +
                      "TrustServerCertificate=False;" +
                          "Connection Timeout = 30;"
                );

        //establishing connection

        public void SetConnection()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)

                {
                    connection.Open();
                    Console.WriteLine("Connected successfully.");

                    Console.WriteLine("Press any key to finish...");
                    Console.ReadKey(true);
                }
                else
                {
                    connection.Close();
                    connection.Open();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("ex.Message");
            }
        }
    }
}


