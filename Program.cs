namespace Giveaway
{
    internal static class Program
    {
		/// <summary>
		///  The main entry point for the application.
		/// </summary>

		///Version:         1.7.1
		///Date:            2023-04-30 01:53 UTC
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