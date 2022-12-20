using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Data;

namespace KohinorData.DbAccess
{
    //Dapper Data Access Guide1: Simple C# Data Access with Dapper and SQL - Minimal API Project Part 1
    //https://www.youtube.com/watch?v=dwMFg6uxQ0I

    //Dapper Data Access Guide2: ASP.NET MVC Data Access in C# - The complete data path from database to display and back
    //https://www.youtube.com/watch?v=bIiEv__QNxw&list=PLLWMQd6PeGY3b89Ni7xsNZddi9wD5Esv2&index=14

    //IMPORTANT TO READ https://stackoverflow.com/questions/6026621/should-i-use-static-class-for-database-connectivity-in-c-net 

    //https://www.youtube.com/watch?v=Jhy1OFg8go0
    public class SqlDataAccess
    {

        private readonly IConfiguration _configuration;
        public SqlDataAccess(IConfiguration configuration)
        {
            _configuration = configuration;
            ConnectionString = _configuration.GetConnectionString("ReportsTestDB");
            providerName = "System.Data.SqlClient";
        }

        public string ConnectionString { get; }
        public string providerName { get; }

        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(ConnectionString);
            }
        }

    }
}
