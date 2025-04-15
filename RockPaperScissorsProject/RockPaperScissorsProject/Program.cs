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

            // make game manager instance
            gameManager = new GameManager();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainWindow());
        }
    }
}