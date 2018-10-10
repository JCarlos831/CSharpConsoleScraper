using System;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleScraper
{
    public class SqlDataAccess
    {
        public static void CreateConnection()
        {
            string connectionString = null;

            connectionString = "Data Source=localhost;Initial Catalog=FinanceScraper;User Id=SA;Password=3eggWhites";
            
            var cnn = new SqlConnection(connectionString);
            try
            {
                cnn.Open();
                Console.WriteLine("Connection Open!");
                try
                {
                    using (SqlCommand command = new SqlCommand(
                        "INSERT INTO Stock_Info (symbol, last_price, currency) VALUES('ABCD', 123, 'USD')", cnn))
                    {
                        command.ExecuteNonQuery();
                        Console.WriteLine("Inserted records");
                        cnn.Close();
                        Console.WriteLine("closed connection.");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}