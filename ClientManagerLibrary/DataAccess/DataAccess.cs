using ClientManagerLibrary.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        public static async Task<List<T>> ExecuteSQLCommand<T>(string command, CommandType commandType, params SqlParameter[] parameters)
        {
            // TODO - make as universal sql executor
            List<T> users = new List<T>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();
                SqlCommand sqlCommand = connection.CreateCommand();

                sqlCommand.Parameters.AddRange(parameters);

                sqlCommand.CommandText = command;
                sqlCommand.CommandType = commandType;

                SqlDataReader result = await sqlCommand.ExecuteReaderAsync();
            }

            return users;

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

        public static async Task<(int?, int?)> TryUserLogin(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                byte[] data = Encoding.UTF8.GetBytes(password);
                data = System.Security.Cryptography.SHA256.HashData(data);
                string cryptPassword = Encoding.UTF8.GetString(data);

                string command = "CLIENT_MANAGER.USER_AUTHORIZATION";

                await connection.OpenAsync();
                SqlCommand sqlCommand = connection.CreateCommand();
                
                SqlParameter[] parameters =
                {
                    new SqlParameter("@USERNAME", username),
                    new SqlParameter("@CRYPTPASSWORD", cryptPassword),
                    new SqlParameter
                    {
                        ParameterName = "@USER_ID",
                        SqlDbType = SqlDbType.Int,
                        Direction = ParameterDirection.Output
                    },
                    new SqlParameter
                    {
                        ParameterName = "@PERMISSIONS_LEVEL",
                        SqlDbType = SqlDbType.Int,
                        Direction = ParameterDirection.Output
                    },
                };

                sqlCommand.Parameters.AddRange(parameters);

                sqlCommand.CommandText = command;
                sqlCommand.CommandType = CommandType.StoredProcedure;

                await sqlCommand.ExecuteNonQueryAsync();

                if (sqlCommand.Parameters["@USER_ID"].SqlDbType == SqlDbType.Int && sqlCommand.Parameters["@PERMISSIONS_LEVEL"].SqlDbType == SqlDbType.Int)
                {
                    int userId = (int)sqlCommand.Parameters["@USER_ID"].Value;
                    int permissionsLevel = (int)sqlCommand.Parameters["@PERMISSIONS_LEVEL"].Value;
                    return (userId, permissionsLevel);
                }
                

                return (null, null);

            }
        }

        public static async Task<bool> ValidateUserRegistration(string username, string password)
        {
            if (username.Length < 3 || password.Length < 3)
            {
                return false;
            }

            if (await IsUserExists(username))
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// For console tests only
        /// </summary>
        /// <returns>All users</returns>
        public static async Task<List<User>> GetAllUsers()
        {
            List<User> users = new List<User>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string command = "SELECT * FROM CLIENT_MANAGER.USERS";

                await connection.OpenAsync();
                SqlCommand sqlCommand = connection.CreateCommand();

                sqlCommand.CommandText = command;
                sqlCommand.CommandType = CommandType.Text;

                SqlDataReader result = await sqlCommand.ExecuteReaderAsync();

                while (await result.ReadAsync())
                {
                    users.Add(
                            new User()
                            {
                                Id = result.GetInt32("ID"),
                                UserName = result.GetString("USER_LOGIN")
                            }
                        );
                }
            }

            return users;

        }

        public static async Task<BindingList<Client>> GetUserClients(int userId, int pageNo, int itemsPerPage)
        {
            BindingList<Client> clients = new BindingList<Client>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string command = "CLIENT_MANAGER.GET_USER_CLIENTS";

                await connection.OpenAsync();
                SqlCommand sqlCommand = connection.CreateCommand();

                SqlParameter[] parameters =
                {
                    new SqlParameter("@USER_ID", userId),
                    new SqlParameter("@PAGE_NO", pageNo),
                    new SqlParameter("@ITEMS_PER_PAGE", itemsPerPage),
                };

                sqlCommand.Parameters.AddRange(parameters);

                sqlCommand.CommandText = command;
                sqlCommand.CommandType = CommandType.StoredProcedure;

                SqlDataReader result = await sqlCommand.ExecuteReaderAsync();

                while (await result.ReadAsync())
                {
                    clients.Add(
                            new Client()
                            {
                                Id = result.GetInt32("ID"),
                                SurName = result.GetString("CLIENT_SURNAME"),
                                Name = result.GetString("CLIENT_NAME"),
                                Gender = result.GetBoolean("GENDER") ? 1 : 0,
                                isVIP = result.GetBoolean("IS_VIP"),
                                // TODO - AccountsId
                                AccountsId = -1
                            }
                        );
                }
            }

            return clients;

        }

        public static async Task<List<Account>> GetClientAccounts(int clientId)
        {
            List<Account> accounts = new List<Account>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string command = "SELECT * FROM CLIENT_MANAGER.CLIENT_ACCOUNTS WHERE CLIENT_ID = @CLIENT_ID";

                await connection.OpenAsync();
                SqlCommand sqlCommand = connection.CreateCommand();

                SqlParameter[] parameters =
                {
                    new SqlParameter("@CLIENT_ID", clientId),
                };

                sqlCommand.Parameters.AddRange(parameters);

                sqlCommand.CommandText = command;
                sqlCommand.CommandType = CommandType.Text;

                SqlDataReader result = await sqlCommand.ExecuteReaderAsync();

                while (await result.ReadAsync())
                {
                    accounts.Add(
                            new Account()
                            {
                                Id = result.GetInt32("ID"),
                                Code = result.GetString("CODE"),
                                Balance = result.GetDecimal("BALANCE")
                            }
                        );
                }
            }

            return accounts;
        }

        //TODO - update a list of client data
        public static async Task<bool> UpdateClient(int clientId, string surName, string fullname)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string command = """
                    UPDATE CLIENT_MANAGER.CLIENTS
                    SET CLIENT_NAME = @CLIENT_NAME,
                    CLIENT_SURNAME = @CLIENT_SURNAME
                    WHERE ID = @CLIENT_ID
                    """;

                await connection.OpenAsync();
                SqlCommand sqlCommand = connection.CreateCommand();

                SqlParameter[] parameters =
                {
                    new SqlParameter("@CLIENT_ID", clientId),
                    new SqlParameter("@CLIENT_SURNAME", surName),
                    new SqlParameter("@CLIENT_NAME", fullname),
                };

                sqlCommand.Parameters.AddRange(parameters);

                sqlCommand.CommandText = command;
                sqlCommand.CommandType = CommandType.Text;

                SqlDataReader result = await sqlCommand.ExecuteReaderAsync();

            }

            return true;
        }

        public static async Task<int> CreateNewClient(string surname, string name, int gender, int managerId)
        {
            int clientId = -1;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string command = "CLIENT_MANAGER.CREATE_CLIENT";

                await connection.OpenAsync();
                SqlCommand sqlCommand = connection.CreateCommand();

                 

                SqlParameter[] parameters =
                {
                    new SqlParameter
                    {
                        ParameterName = "@CLIENT_ID",
                        SqlDbType = SqlDbType.Int,
                        Direction = ParameterDirection.Output
                    },
                    new SqlParameter("@CLIENT_SURNAME", surname),
                    new SqlParameter("@CLIENT_NAME", name),
                    new SqlParameter("@GENDER", gender),
                    new SqlParameter("@MANAGER_ID", managerId),
                };

                sqlCommand.Parameters.AddRange(parameters);

                sqlCommand.CommandText = command;
                sqlCommand.CommandType = CommandType.StoredProcedure;

                await sqlCommand.ExecuteNonQueryAsync();

                clientId = (int)sqlCommand.Parameters["@CLIENT_ID"].Value;

            }

            return clientId;
        }
    }
}
