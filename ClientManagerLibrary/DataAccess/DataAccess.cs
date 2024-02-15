﻿using ClientManagerLibrary.Models;
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

        static public async Task<bool> ValidateUserRegistration(string username, string password)
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
        /// For tests only
        /// </summary>
        /// <returns>All users</returns>
        static public async Task<List<User>> GetAllUsers()
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
                            new User() { 
                                Id = result.GetInt32("ID"),
                                Name = result.GetString("USER_LOGIN")
                            }
                        );
                }
            }

            return users;

        }

        static public async Task<List<Client>> GetUserClients()
        {
            List<Client> clients = new List<Client>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string command = "SELECT * FROM CLIENT_MANAGER.CLIENTS";

                await connection.OpenAsync();
                SqlCommand sqlCommand = connection.CreateCommand();

                sqlCommand.CommandText = command;
                sqlCommand.CommandType = CommandType.Text;

                SqlDataReader result = await sqlCommand.ExecuteReaderAsync();

                while (await result.ReadAsync())
                {
                    clients.Add(
                            new Client()
                            {
                                Id = result.GetInt32("ID"),
                                SurName = result.GetString("CLIENT_SURNAME"),
                                FullName = result.GetString("CLIENT_FULL_NAME")
                            }
                        );
                }
            }

            return clients;

        }

        static public async Task<List<Account>> GetClientAccounts(int clientId)
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
        static async public Task<bool> UpdateClient(int clientId, string surName, string fullname)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string command = """
                    UPDATE CLIENT_MANAGER.CLIENTS
                    SET CLIENT_FULL_NAME = @CLIENT_FULL_NAME,
                    CLIENT_SURNAME = @CLIENT_SURNAME
                    WHERE ID = @CLIENT_ID
                    """;

                await connection.OpenAsync();
                SqlCommand sqlCommand = connection.CreateCommand();

                SqlParameter[] parameters =
                {
                    new SqlParameter("@CLIENT_ID", clientId),
                    new SqlParameter("@CLIENT_SURNAME", surName),
                    new SqlParameter("@CLIENT_FULL_NAME", fullname),
                };

                sqlCommand.Parameters.AddRange(parameters);

                sqlCommand.CommandText = command;
                sqlCommand.CommandType = CommandType.Text;

                SqlDataReader result = await sqlCommand.ExecuteReaderAsync();

            }

            return true;
        }
    }
}
