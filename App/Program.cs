using InstalmentsProject.Operations;
using InstalmentsProject.UI;

namespace InstalmentsProject.App
{
    internal class Program
    {
        public static string? newSession = null;
        public static int maxTry = 3;
        static void Main()
        {
            CountdownInstalments.CountDownInstalments();
            Console.Clear();
            Utility.ScreenColor("Congratulation!!! You have cleared your debts");
            bool session = false;
            int numTries = 0;
            while (session != true)
            {

                while (newSession != "1" || newSession != "2" || numTries < 4)
                {
                    numTries++;
                    Console.WriteLine("Press 1 to buy another product or 2 to Terminate");
                    newSession = Console.ReadLine();

                    if (newSession.Contains("1"))
                    {
                        numTries = 0;
                        CountdownInstalments.CountDownInstalments();
                    }
                    else if (newSession.Contains("2"))
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        Utility.ErrorMessage("Check the option and try again");
                    }
                    if (numTries == 3)
                    {
                        Utility.ErrorMessage("This is your last attempt");
                    }
                    else if (numTries == 4)
                    {
                        Environment.Exit(0);
                    }

                }
            }
        }
    }
}