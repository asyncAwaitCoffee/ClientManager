namespace ClientManagerForms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // TODO - LoginForm should be first to open
            Application.Run(new ClientsForm());
            //Application.Run(new LoginForm());
        }
    }
}