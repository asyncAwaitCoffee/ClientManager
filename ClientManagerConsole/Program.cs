using System.Text;

namespace ClientManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Console!");
            Console.WriteLine("Enter 1 - for registration");
            Console.WriteLine("Enter 2 - for log in");
            Console.WriteLine("Enter 0 - for exit");
            while (true)
            {
                Console.Write("Your choice: ");
                string pick = Console.ReadLine();

                if (pick == "1")
                {
                    Console.Write("Enter your login: ");
                    string login = Console.ReadLine();
                    Console.WriteLine($"Enter your password for login [ {login} ].");
                    Console.Write($"Only chars and integers allowed: ");

                    string password = Users.BuildPassword();

                    if (Users.ValidateUserRegistration(login, password))
                    {
                        Users.RegisterNewUser(login, password);
                        WriteMessageInColor($"Login [ {login} ] successfully registered!", ConsoleColor.Green);
                    }
                    else
                    {
                        WriteMessageInColor($"Registration for login [ {login} ] fails!", ConsoleColor.Red);
                    }

                    continue;
                }

                if (pick == "2")
                {
                    Console.Write("Enter your login: ");
                    string login = Console.ReadLine();
                    Console.Write($"Enter your password for login [ {login} ]: ");
                    string password = Users.BuildPassword();

                    if (Users.ValidateUserLogin(login, password))
                    {
                        WriteMessageInColor($"Welcome, [ {login} ] !", ConsoleColor.Green);
                        break;
                    }
                    else
                    {
                        WriteMessageInColor("Login or password is incorrect.", ConsoleColor.Red);
                    }
                }

                if (pick == "0")
                {
                    WriteMessageInColor("Bye!", ConsoleColor.Yellow);
                    return;
                }
            }

            // TODO - logic after user loged in
            Console.WriteLine("What is it going to be today?");
            Console.ReadLine();
        }

        

        static void WriteMessageInColor(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }

    static class Users
    {
        static public List<User> UsersList { get; } = [
            new() { Username = "test", Password = "123" },
        ];

        /// <summary>
        /// Registers new user
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        static public void RegisterNewUser(string username, string password)
        {
            UsersList.Add(new User(username, password));
        }

        /// <summary>
        /// Checks if it is possible to register a user
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        static public bool ValidateUserRegistration(string username, string password)
        {
            if (username.Length < 3 || password.Length < 3)
            {
                return false;
            }

            if (UsersList.Any(u => u.Username == username))
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Checks if it is possible to log in
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        static public bool ValidateUserLogin(string login, string password)
        {
            return UsersList.Contains(new User { Username = login, Password = password });
        }

        /// <summary>
        /// Makes password invisible while entering
        /// </summary>
        /// <returns>String with password</returns>
        static public string BuildPassword()
        {
            StringBuilder sb = new StringBuilder();

            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine();
                    break;
                }

                if (!char.IsLetterOrDigit(key.KeyChar))
                {
                    continue;
                }

                sb.Append(key.KeyChar);
            }

            return sb.ToString();
        }



    }

    readonly record struct User(string Username, string Password);
}
