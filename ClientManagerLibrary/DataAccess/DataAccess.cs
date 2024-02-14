using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagerLibrary.DataAccess
{
    public static class DataAccess
    {
        private static readonly string connectionString = "Server=MSI;Database=COURSES_DB;Trusted_Connection=True;TrustServerCertificate=True;";
        /// <summary>
        /// For tests only
        /// </summary>
        /// <param name="command">SQL comand string</param>
        public static async void ExecuteSQLCommand(string command)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();
                SqlCommand sqlCommand = connection.CreateCommand();

                sqlCommand.CommandText = command;
                sqlCommand.CommandType = CommandType.Text;

                int result = await sqlCommand.ExecuteNonQueryAsync();

                await Console.Out.WriteLineAsync($"{result}");
            }


        }
        /// <summary>
        /// Saves user's login and encrypted password to the DB
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        public static async void SaveUserToDB(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                byte[] data = Encoding.UTF8.GetBytes(password);
                data = System.Security.Cryptography.SHA256.HashData(data);
                string cryptPassword = Encoding.UTF8.GetString(data);

                string command = "INSERT INTO CLIENT_MANAGER.USERS(USER_LOGIN, ENCRYPTED_PASSWORD) VALUES (@username, @password)";

                await connection.OpenAsync();
                SqlCommand sqlCommand = connection.CreateCommand();

                SqlParameter[] parameters =
                {
                    new SqlParameter("@username", username),
                    new SqlParameter("@password", cryptPassword)
                };

                sqlCommand.Parameters.AddRange(parameters);

                sqlCommand.CommandText = command;
                sqlCommand.CommandType = CommandType.Text;

                int result = await sqlCommand.ExecuteNonQueryAsync();

            }
        }

        public static async Task<bool> IsUserExists(string username)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string command = "SELECT 1 FROM CLIENT_MANAGER.USERS WHERE USER_LOGIN = @username";

                await connection.OpenAsync();
                SqlCommand sqlCommand = connection.CreateCommand();

                SqlParameter parameter = new SqlParameter("@username", username);

                sqlCommand.Parameters.Add(parameter);

                sqlCommand.CommandText = command;
                sqlCommand.CommandType = CommandType.Text;

                int? result = (int?)await sqlCommand.ExecuteScalarAsync();

                return result is not null;

            }
        }

        public static async Task<bool> TryUserLogin(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                byte[] data = Encoding.UTF8.GetBytes(password);
                data = System.Security.Cryptography.SHA256.HashData(data);
                string cryptPassword = Encoding.UTF8.GetString(data);

                string command = "SELECT 1 FROM CLIENT_MANAGER.USERS WHERE USER_LOGIN = @username AND ENCRYPTED_PASSWORD = @cryptPassword";

                await connection.OpenAsync();
                SqlCommand sqlCommand = connection.CreateCommand();

                SqlParameter[] parameters =
                {
                    new SqlParameter("@username", username),
                    new SqlParameter("@cryptPassword", cryptPassword)
                };

                sqlCommand.Parameters.AddRange(parameters);

                sqlCommand.CommandText = command;
                sqlCommand.CommandType = CommandType.Text;

                int? result = (int?)await sqlCommand.ExecuteScalarAsync();

                return result is not null;

            }
        }
    }
}
