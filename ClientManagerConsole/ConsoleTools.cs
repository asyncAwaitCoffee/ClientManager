using System.Text;

namespace ClientManagerConsole
{
    static class ConsoleTools
    {
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

        static public void WriteMessageInColor(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }


    }
}
