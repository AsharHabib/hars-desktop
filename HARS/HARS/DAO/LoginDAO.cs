using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using HARS.Models;

namespace HARS.DAO
{
    public class LoginDAO
    {
        private static string connectionString = "";
        public static User VerifyLoginCredentials(string username, string password)
        {
            var conn = new NpgsqlConnection(connectionString);
            conn.Open();
            string sql = "SELECT * FROM managers WHERE manager_username ='" + username + "' AND manager_password = '" + password + "';";
            var cmd = new NpgsqlCommand(sql, conn);

            NpgsqlDataReader rdr = cmd.ExecuteReader();
            User? user = null;
            while (rdr.Read())
            {
                user = new User(rdr.GetInt32(0), rdr.GetString(1), rdr.GetString(2), rdr.GetString(3), rdr.GetString(4), rdr.GetString(5));
            }
            conn.Close();
            return user;
        }
    }
}