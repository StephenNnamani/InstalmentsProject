using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstalmentsProject.UI
{
    public static class Utility
    {
        private readonly static string line = "==============================================================================";

        public static string Lines()
        {
            return line;
        }
        public static void DisplayCompany(string input)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(input);
            Console.ResetColor();
        }
        public static void ErrorMessage(string input)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(input);
            Console.ResetColor();
        }
        public static void ScreenColor(string input)
        {
            Console.WriteLine(input);
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Write("");
            Thread.Sleep(300);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("");
            Thread.Sleep(300);
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Write("");
            Thread.Sleep(300);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("");
            Thread.Sleep(00);
            Console.ResetColor();
        }
    }
}
