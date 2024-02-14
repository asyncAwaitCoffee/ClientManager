using ClientManagerConsole;
using ClientManagerLibrary.DataAccess;
using System.Text;

namespace ClientManager
{
    internal class Program
    {
        static async Task Main(string[] args)
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
                    string username = Console.ReadLine();
                    Console.WriteLine($"Enter your password for login [ {username} ].");
                    Console.Write($"Only chars and integers allowed: ");

                    string password = ConsoleTools.BuildPassword();

                    if (await DataAccess.ValidateUserRegistration(username, password))
                    {
                        DataAccess.SaveUserToDB(username, password);
                        ConsoleTools.WriteMessageInColor($"Login [ {username} ] successfully registered!", ConsoleColor.Green);
                    }
                    else
                    {
                        ConsoleTools.WriteMessageInColor($"Registration for login [ {username} ] fails!", ConsoleColor.Red);
                    }

                    continue;
                }

                if (pick == "2")
                {
                    Console.Write("Enter your login: ");
                    string username = Console.ReadLine();
                    Console.Write($"Enter your password for login [ {username} ]: ");
                    string password = ConsoleTools.BuildPassword();

                    if (await DataAccess.TryUserLogin(username, password))
                    {
                        ConsoleTools.WriteMessageInColor($"Welcome, [ {username} ] !", ConsoleColor.Green);
                        break;
                    }
                    else
                    {
                        ConsoleTools.WriteMessageInColor("Login or password is incorrect.", ConsoleColor.Red);
                    }
                }

                if (pick == "3")
                {
                    // test select from db
                    var list = await DataAccess.GetAllUsers();
                    foreach (var item in list)
                    {
                        Console.WriteLine((item.Id, item.Name));
                    }
                    
                }

                if (pick == "0")
                {
                    ConsoleTools.WriteMessageInColor("Bye!", ConsoleColor.Yellow);
                    return;
                }
            }

            // TODO - logic after user loged in
            Console.WriteLine("What is it going to be today?");
            Console.ReadLine();
        }
    }
}
