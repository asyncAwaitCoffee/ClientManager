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

        private static async Task<SqlCommand> CreateSqlCommand(SqlConnection connection, string command, params SqlParameter[] sqlParameters)
        {
            await connection.OpenAsync();
            SqlCommand sqlCommand = connection.CreateCommand();

            sqlCommand.Parameters.AddRange(sqlParameters);

            sqlCommand.CommandText = command;
            sqlCommand.CommandType = CommandType.StoredProcedure;

            return sqlCommand;
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

                SqlCommand sqlCommand = await CreateSqlCommand(
                    connection,
                    "CLIENT_MANAGER.USER_REGISTRATION",
                    new SqlParameter("@USER_LOGIN", username),
                    new SqlParameter("@CRYPTPASSWORD", cryptPassword)
                    );

                await sqlCommand.ExecuteNonQueryAsync();
            }
        }

        public static async Task<bool> IsUserExists(string username)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = await CreateSqlCommand(
                    connection,
                    "CLIENT_MANAGER.IS_USER_EXISTS",
                    new SqlParameter("@USER_LOGIN", username)
                    );                

                bool result = (bool)await sqlCommand.ExecuteScalarAsync();

                return result;

            }
        }

        public static async Task<(int?, int?)> TryUserLogin(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                byte[] data = Encoding.UTF8.GetBytes(password);
                data = System.Security.Cryptography.SHA256.HashData(data);
                string cryptPassword = Encoding.UTF8.GetString(data);

                SqlCommand sqlCommand = await CreateSqlCommand(
                        connection,
                        "CLIENT_MANAGER.USER_AUTHORIZATION",
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
                        }
                    );

                await sqlCommand.ExecuteNonQueryAsync();

                if (sqlCommand.Parameters["@USER_ID"].Value != DBNull.Value && sqlCommand.Parameters["@PERMISSIONS_LEVEL"].Value != DBNull.Value)
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
        /// Gets all users
        /// </summary>
        /// <returns>All users</returns>
        public static async Task<List<User>> GetAllUsers()
        {
            List<User> users = new List<User>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = await CreateSqlCommand(
                    connection,
                    "CLIENT_MANAGER.GET_ALL_USERS"
                    );

                SqlDataReader result = await sqlCommand.ExecuteReaderAsync();

                while (await result.ReadAsync())
                {
                    users.Add(
                            new User()
                            {
                                Id = result.GetInt32("ID"),
                                UserName = result.GetString("USER_LOGIN"),
                                PermissionLevel = (int)result.GetByte("PERMISSIONS_LEVEL")
                            }
                        );
                }
            }

            return users;

        }
        /// <summary>
        /// Gets all users and marks non-subordinates as null
        /// </summary>
        /// <returns>All users</returns>
        public static async Task<BindingList<User>> GetAllUsersForManager(string username)
        {
            BindingList<User> users = new BindingList<User>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = await CreateSqlCommand(
                    connection,
                    "CLIENT_MANAGER.GET_ALL_USERS_FOR_MANAGER",
                    new SqlParameter("@USER_LOGIN", username)
                    );

                SqlDataReader result = await sqlCommand.ExecuteReaderAsync();

                while (await result.ReadAsync())
                {
                    users.Add(
                            new User()
                            {
                                Id = result.GetInt32("ID"),
                                UserName = result.GetString("USER_LOGIN"),
                                ManagedId = result.GetInt32("MANAGER_USER_ID"),
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
                SqlCommand sqlCommand = await CreateSqlCommand(
                    connection,
                    "CLIENT_MANAGER.GET_USER_CLIENTS",
                    new SqlParameter("@USER_ID", userId),
                    new SqlParameter("@PAGE_NO", pageNo),
                    new SqlParameter("@ITEMS_PER_PAGE", itemsPerPage)
                    );
                

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
                                AccountsId = -1,
                                ClientManager = result.GetString("USER_LOGIN"),
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
                SqlCommand sqlCommand = await CreateSqlCommand(
                    connection,
                    "CLIENT_MANAGER.GET_CLIENT_ACCOUNTS",
                    new SqlParameter("@CLIENT_ID", clientId)
                    );                

                SqlDataReader result = await sqlCommand.ExecuteReaderAsync();

                while (await result.ReadAsync())
                {
                    accounts.Add(
                            new Account()
                            {
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
                SqlCommand sqlCommand = await CreateSqlCommand(
                    connection,
                    "CLIENT_MANAGER.UPDATE_CLIENT_INFO",
                    new SqlParameter("@CLIENT_ID", clientId),
                    new SqlParameter("@CLIENT_SURNAME", surName),
                    new SqlParameter("@CLIENT_NAME", fullname)
                    );

                SqlDataReader result = await sqlCommand.ExecuteReaderAsync();

            }

            return true;
        }

        public static async Task<int> CreateNewClient(string surname, string name, int gender, int managerId)
        {
            int clientId = -1;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = await CreateSqlCommand(
                    connection,
                    "CLIENT_MANAGER.CREATE_CLIENT",
                    new SqlParameter
                    {
                        ParameterName = "@CLIENT_ID",
                        SqlDbType = SqlDbType.Int,
                        Direction = ParameterDirection.Output
                    },
                    new SqlParameter("@CLIENT_SURNAME", surname),
                    new SqlParameter("@CLIENT_NAME", name),
                    new SqlParameter("@GENDER", gender),
                    new SqlParameter("@MANAGER_ID", managerId)
                    );

                await sqlCommand.ExecuteNonQueryAsync();

                clientId = (int)sqlCommand.Parameters["@CLIENT_ID"].Value;

            }

            return clientId;
        }

        public static async void UpdateUserPermissionsLevel(string username, int permissionsLevel)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = await CreateSqlCommand(
                    connection,
                    "CLIENT_MANAGER.UPDATE_USER_PERMISSIONS_LEVEL",
                    new SqlParameter("@USER_LOGIN", username),
                    new SqlParameter("@PERMISSIONS_LEVEL", permissionsLevel)
                    );

                await sqlCommand.ExecuteNonQueryAsync();

            }
        }
        public static async Task<Client> GetClientByAccount(string code)
        {
            Client client;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = await CreateSqlCommand(
                    connection,
                    "CLIENT_MANAGER.GET_CLIENT_BY_ACCOUNT",
                    new SqlParameter("@ACCOUNT_CODE", code)
                    );

                SqlDataReader result = await sqlCommand.ExecuteReaderAsync();

                if (!result.HasRows)
                    return null;

                await result.ReadAsync();

                client = new Client()
                {
                    Id = result.GetInt32("ID"),
                    SurName = result.GetString("CLIENT_SURNAME"),
                    Name = result.GetString("CLIENT_NAME"),
                };


            }

            return client;
        }

        public static async Task<DateTime?> CreateTransaction(int clientIdFrom, int clientIdTo, string accountFrom, string accountTo, decimal amount, bool isImidiate)
        {
            if (amount <= 0 || clientIdFrom == 0 || clientIdTo == 0 || accountFrom == accountTo)
            {
                return null;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = await CreateSqlCommand(
                    connection,
                    "CLIENT_MANAGER.CREATE_TRANSACTION",
                    new SqlParameter("@CLIENT_FROM", clientIdFrom),
                    new SqlParameter("@CLIENT_TO", clientIdTo),
                    new SqlParameter("@ACCOUNT_FROM", accountFrom),
                    new SqlParameter("@ACCOUNT_TO", accountTo),
                    new SqlParameter("@AMOUNT", amount),
                    new SqlParameter("@IS_IMIDIATE", isImidiate),
                    new SqlParameter
                    {
                        ParameterName = "@TRANSFER_DATE_TIME",
                        SqlDbType = SqlDbType.DateTime,
                        Direction = ParameterDirection.Output
                    }
                    );

                await sqlCommand.ExecuteNonQueryAsync();
                return (DateTime?)(sqlCommand.Parameters["@TRANSFER_DATE_TIME"].Value == DBNull.Value ? null : sqlCommand.Parameters["@TRANSFER_DATE_TIME"].Value);

            }
        }

        public static async Task<List<Transaction>> GetFilteredTransactions(string? accountFrom, string? accountTo)
        {
            List<Transaction> filteredTransactions = new List<Transaction>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = await CreateSqlCommand(
                    connection,
                    "CLIENT_MANAGER.GET_TRANSACTIONS_BY_FILTER",
                    new SqlParameter("@ACCOUNT_FROM", accountFrom == null ? DBNull.Value : accountFrom),
                    new SqlParameter("@ACCOUNT_TO", accountTo == null ? DBNull.Value : accountTo)
                    );

                SqlDataReader result = await sqlCommand.ExecuteReaderAsync();

                while (await result.ReadAsync())
                {
                    filteredTransactions.Add(
                            new Transaction()
                            {
                                Id = result.GetInt32("ID"),
                                ClientFrom = new Client() {
                                    Id = result.GetInt32("CLIENT_FROM"),
                                    SurName = result.GetString("CLIENT_SURNAME_FROM"),
                                    Name = result.GetString("CLIENT_NAME_FROM") },
                                ClientTo = new Client()
                                {
                                    Id = result.GetInt32("CLIENT_TO"),
                                    SurName = result.GetString("CLIENT_SURNAME_TO"),
                                    Name = result.GetString("CLIENT_NAME_TO")
                                },
                                AccountFrom = result.GetString("ACCOUNT_FROM"),
                                AccountTo = result.GetString("ACCOUNT_TO"),
                                Amount = result.GetDecimal("AMOUNT"),
                                DateTimeCreated = result.GetDateTime("CREATION_DATE_TIME"),
                                DateTimeTranfered = result.IsDBNull("TRANSFER_DATE_TIME") ? null : result.GetDateTime("TRANSFER_DATE_TIME")
                            }
                        );
                }
            }

            return filteredTransactions;
        }

        public static async Task<DateTime?> ConductTransaction(int transactionId)
        {
            DateTime? result;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = await CreateSqlCommand(
                    connection,
                    "CLIENT_MANAGER.CONDUCT_TRANSACTION",
                    new SqlParameter("@TRANSACTION_ID", transactionId),
                    new SqlParameter
                    {
                        ParameterName = "@TRANSFER_DATE_TIME",
                        SqlDbType = SqlDbType.DateTime,
                        Direction = ParameterDirection.Output
                    }
                    );                

                await sqlCommand.ExecuteNonQueryAsync();

                result = (DateTime?)(sqlCommand.Parameters["@TRANSFER_DATE_TIME"].Value == DBNull.Value ? null : sqlCommand.Parameters["@TRANSFER_DATE_TIME"].Value);
            }

            return result;
        }

        public static async Task<int> CreateAccount(int clientId, string accountCode)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = await CreateSqlCommand(
                    connection,
                    "CLIENT_MANAGER.CREATE_ACCOUNT",
                    new SqlParameter("@CLIENT_ID", clientId),
                    new SqlParameter("@ACCOUNT_CODE", accountCode)
                    );

                return await sqlCommand.ExecuteNonQueryAsync();
            }
        }

        public static async Task<int> AssignManagers(string username, List<int> managersToAssign, List<int> managersToUnassign)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = await CreateSqlCommand(
                    connection,
                    "CLIENT_MANAGER.ASSIGN_MANAGERS",
                    new SqlParameter("@USER_LOGIN", username),
                    new SqlParameter("@MANAGERS_TO_ASSIGN", string.Join(',', managersToAssign)),
                    new SqlParameter("@MANAGERS_TO_UNASSIGN", string.Join(',', managersToUnassign))
                    );

                return await sqlCommand.ExecuteNonQueryAsync();
            }
        }
        public static async Task<Report> GetAccountsReport(string accounts)
        {
            Report report = new Report() { Header = "Accounts Report" };

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = await CreateSqlCommand(
                    connection,
                    "CLIENT_MANAGER.GET_DATA_FOR_ACCOUNTS_REPORT",
                    new SqlParameter("@ACCOUNT_CODES", accounts)
                    );

                SqlDataReader result = await sqlCommand.ExecuteReaderAsync();

                // TODO - move all report logic and formatting to the Report class
                while (await result.ReadAsync())
                {
                    report.Lines.Add(
                            result.GetString("CODE") + " --- " + result.GetDecimal("BALANCE").ToString()
                        );
                }
            }

            return report;
        }
    }
}
