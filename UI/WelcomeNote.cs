using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstalmentsProject.UI
{
    internal class WelcomeNote
    {
        public static void Welcome()
        {
            string lines = Utility.Lines();
            Utility.DisplayCompany(lines);
            Utility.DisplayCompany("Welcome to Stephen's Shops");
            Utility.DisplayCompany(lines);
            Utility.DisplayCompany("Please what product do you want?");
            Console.WriteLine("");
        }
    }
}
