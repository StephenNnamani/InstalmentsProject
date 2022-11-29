using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InstalmentsProject.UI;

namespace InstalmentsProject.Operations
{
    internal static class DisplayAndCollectPrices
    {
        public static int asus = 120000; public static int hpElitebook = 100000; public static int macBookAir = 720000; public static int alianWare = 1200000;
        public static double Price { get; set; }
        public static void Products()
        {
            WelcomeNote.Welcome();
            Console.WriteLine("1. Asus 63D\tN120,000 \t\t2. HP Elitebook 8570p\tN100,000 \n3. MacBook Air \tN720,000 \t\t4. AlienWare 2022\tN1,200,000 ");
            //int price = 0;
            int selection = 0;
            int numTries = 3;
            while (selection < 1 || selection > 4)
            {
                try
                {
                    if (numTries != 0)
                    {
                        Utility.Lines();
                        Utility.DisplayCompany($"\t\t\tYou {numTries} numbers of tries remaining");
                        Console.WriteLine("");
                        Utility.DisplayCompany("Kindly select the number of the product you wish to buy!!");
                        selection = Convert.ToInt32(Console.ReadLine());
                        numTries--;
                    }
                    else if (numTries == 1)
                    {
                        Utility.ErrorMessage("This is your last opportunity");
                    }
                    else if (numTries == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("");
                        Console.WriteLine(Utility.Lines());
                        Utility.DisplayCompany("Thank You for contacting us, Hope to see you again\n\n\n");
                        Environment.Exit(0);
                    }

                }
                catch
                {
                    numTries--;
                    //selection = 0;
                }

            }
            if (selection == 1)
            {
                Price = asus;
            }
            else if (selection == 2)
            {
                Price = hpElitebook;
            }
            else if (selection == 3)
            {
                Price = macBookAir;
            }
            else if (selection == 4)
            {
                Price = alianWare;
            }

        }
    }
}
