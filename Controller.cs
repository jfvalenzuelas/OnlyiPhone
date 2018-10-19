using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OnlyIphone
{
    class Controller
    {
        /// <summary>
        /// Gets the user.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <returns></returns>
        public static User getUser(string username)
        {
            User user = new User();
            MySqlConnection connection = Connection.getConnection();
            MySqlCommand cmd = new MySqlCommand(String.Format("SELECT username, password FROM user WHERE username='{0}'", username), connection);
            MySqlDataReader reader  = cmd.ExecuteReader();
            while (reader.Read())
            {
                user.Username = reader.GetString(0);
                user.Password = reader.GetString(1);
            }
            connection.Close();
            return user;

        }
    }
}
