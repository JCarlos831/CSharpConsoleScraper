using System.Data.SqlClient;

namespace ConsoleScraper
{
    public class EntryPoint
    {
        
        static void Main()
        {
            GetData.Scrape();
            // SqlDataAccess.CreateConnection();
        }
    }
}