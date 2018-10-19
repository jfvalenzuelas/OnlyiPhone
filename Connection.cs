using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OnlyIphone
{
    /// <summary>
    /// Class that provides the connection to the database
    /// </summary>
    class Connection
    {
        /// <summary>
        /// Gets the connection to Database.
        /// </summary>
        /// <returns></returns>
        public static MySqlConnection getConnection()
        {
            MySqlConnection connect = new MySqlConnection("server=127.0.0.1; database=onlyiphone; Uid=root; pwd=1234;");

            connect.Open();
            return connect;
        }
    }
}
