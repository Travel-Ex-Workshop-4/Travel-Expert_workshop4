using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseAcess
{
    /*
    * Term 2 Threaded Project 
    * Author : Muna. Branden,
    * Date : October 5,2020
    * Course Name : Threaded Project for OOSD
    * Purpose : connect to the database
    */
    public static class TravelExpertsDB
    {
        public static SqlConnection GetConnection()
        {
            string connectionString = @"data source=LocalHost;initial catalog=TravelExperts;integrated security=True";
            return new SqlConnection(connectionString);
        }
    }
}
