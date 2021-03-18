using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Data.SqlClient;

namespace Roommates.Repositories
{
    /// <summary>
    ///  A base class for every other Repository class to inherit from.
    ///  This class is responsible for providing a database connection to each of the repository subclasses
    /// </summary>
    public class BaseRepository
    {
        /// <summary>
        ///  A "connection string" is the address of the database.
        /// </summary>
        private string _connectionString; //we're defining a field here


        /// <summary>
        ///  This constructor will be invoked by subclasses.
        ///  It will save the connection string for later use.
        /// </summary>
        
        public BaseRepository(string connectionString) //this is a constructor
        {
            _connectionString = connectionString;  //"server=localhost\SQLExpress;database=Roommates;integrated security=true"
            //so connectionString is the address of the database which our database is in our localhost which has SQLExpress(which is sequel code)
            //and we're saying find the Roommates kind of picture database in our localhost
            //And set that to _connectionString
        }


        /// <summary>
        ///  Represents a connection to the database.
        ///   This is a "tunnel" to connect the application to the database.
        ///   All communication between the application and database passes through this connection.
        /// </summary>
        protected SqlConnection Connection => new SqlConnection(_connectionString);
    }
}
