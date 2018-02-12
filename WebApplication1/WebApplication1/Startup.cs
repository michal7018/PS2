using Microsoft.Owin;
using Owin;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

[assembly: OwinStartup(typeof(WebApplication1.Startup))]
namespace WebApplication1
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Any connection or hub wire up and configuration should go here
            app.MapSignalR();
        }






        private static List<object[]> getQuery(string message)
        {
            List<object[]> rows = new List<object[]>();

            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = "SERVER=ps2db195000.database.windows.net;DATABASE=mk195000;USER ID=michal7018;PASSWORD=Michal7011;";
                conn.Open();

                SqlCommand command = new SqlCommand(message, conn);

                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        object[] temp = new object[reader.FieldCount];

                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            temp[i] = reader[i];
                        }
                        rows.Add(temp);
                    }
                }
            }
            return rows;
        }







    }
}