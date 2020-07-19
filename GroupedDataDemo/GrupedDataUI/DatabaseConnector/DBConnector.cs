using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace GrupedDataUI.DatabaseConnector
{
    public class DBConnector
    {
        static void Connection()
        {
            SqlConnection conn = new SqlConnection("Data Source =.; Initial Catalog = PraktykiITM; Integrated Security = True");
            conn.Open();
            SqlCommand command = new SqlCommand("INSERT INTO[dbo].[Activity]([ActivityName],[Description],[Date])" + "VALUES('Stuck', 'Crazy fun', '2020-11-12')");
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = conn;
            command.ExecuteNonQuery();
            conn.Close();
        }
    
    }
    
}
