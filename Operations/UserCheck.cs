using InstalmentsProject.Customers;
using InstalmentsProject.UI;

namespace InstalmentsProject.Operations
{
    internal static class UserCheck
    {
        internal static double salary { get; set; }
        public static void userEmployment()
        {

            int employmentStatus = 0;
            bool isEmployed = false;
            Console.WriteLine("\n\nAre you Employed?");
            Utility.DisplayCompany("Press 1 if you are employed\nPress 2 if you are not employed");
            while (employmentStatus <1 || employmentStatus > 2)
            {
                try
                {
                    employmentStatus = Convert.ToInt32(Console.ReadLine());
                    if (employmentStatus == 1)
                    {
                        isEmployed = true;
                        Console.WriteLine("How much is your monthly salary?");
                        salary = int.Parse(Console.ReadLine());
                    }
                    else if (employmentStatus == 2)
                    {
                        isEmployed = false;
                    }
                }
                catch
                {
                    Console.WriteLine("For selecting nothing or wrong option option, the default employment status is set to " +
                        "\"UNEMPLOYED\nKindly contact the Admin to change your employment status");
                }
            }

            while (isEmployed == false)
            {
                Console.WriteLine("Kindly insert your ATM Pin to log in");
                string? ATMPin = Console.ReadLine();
                UserModel user = null;
                int attempt = 3;
                while (user != null || attempt == 0)
                {
                    user = UserLogin.UserChecks(ATMPin);
                    if (attempt == 1)
                    {
                        Console.WriteLine("This is your last attempt");
                    }else if (attempt == 0)
                    {
                        Console.WriteLine("Sorry but you can't continue with the transaction");
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                }
                Console.WriteLine(user.AccBalance);
                int inFullPurchase = 0;
                if (isEmployed == false && user.AccBalance < DisplayAndCollectPrices.Price)
                {
                    Utility.ErrorMessage("OOPS!! You are ineligible to continue with the transaction \nbecause you have no known source of employment " +
                        "and YOUR ACCOUNT BALANCE IS INSUFFICIENT!!!\nKindly email us paymentplans@stephenshop.com");
                    Console.WriteLine("Press any key to exit");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                else if (isEmployed == false && user.AccBalance >= DisplayAndCollectPrices.Price)
                {
                    Console.WriteLine("Thhe only option left to you is to pay in full since you are not employed!!!\nIf you wish to pay in full, We will discount your selected product by 20%" +
                        "\nPress 1 to Pay in full\nPress 2 to discontinue with the purchase");
                    inFullPurchase = int.Parse(Console.ReadLine());
                    if (inFullPurchase == 1)
                    {
                        Console.WriteLine("the first acc bal"+user.AccBalance);
                        double newPrice = Convert.ToDouble(DisplayAndCollectPrices.Price * 0.2);
                        newPrice = DisplayAndCollectPrices.Price - newPrice;
                        user.AccBalance = user.AccBalance - newPrice;
                        Console.WriteLine(user.AccBalance);
                        Console.WriteLine("Thank you for your Patronage!!! We are glad doing business with you");
                        Console.WriteLine("Kindly Press any key to exit");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                    else if (inFullPurchase == 2)
                    {
                        Console.WriteLine("Thank you for contacting us. Unfortunately we weren't able to satify you\nCheck back for other plans when they are ready!!!");
                        Console.WriteLine("Kindly Press any key to exit");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                }
            }
        }
    }
}
