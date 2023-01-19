namespace Giveaway
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        
        ///Version:         1.6
        ///Date:            2023-01-19
        ///Created by:      Pawel "pawgor" Gorski
        ///Description:     Program created to help me manage giveaway on my streams.
        ///
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Strzal_w_10());
        }
    }
}