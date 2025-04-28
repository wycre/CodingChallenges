namespace RockPaperScissorsProject
{
    internal static class Program
    {

        internal static GameManager gameManager;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            MainWindow window = new MainWindow();
            // make game manager instance
            gameManager = new GameManager(window);

            Application.Run(window);

        }
    }
}