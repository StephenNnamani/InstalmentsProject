using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InstalmentsProject.Customers;
using InstalmentsProject.UI;

namespace InstalmentsProject.Operations
{
    
    internal class CountdownInstalments
    {
        public static DateTime dateOfPurchase = DateTime.Now;
        
        internal static void CountDownInstalments()
        {
            Console.WriteLine("Kindly insert your ATM Card for capturing");
            Utility.Loading();
            Console.WriteLine("Kindly insert your ATM Pin to log in");
            string? ATMPin = Console.ReadLine();
            Utility.Loading();
            var user = UserLogin.UserChecks(ATMPin);
            if(user != null)
            {
                double percentage = PaymentOptions.MySelection;
                double deductibleAmount = DisplayAndCollectPrices.Price * percentage;
                double newPrice = DisplayAndCollectPrices.Price;
                while (newPrice! > 0)
                {
                    Console.Clear();
                    Utility.Lines();
                    Utility.DisplayCompany($"The Price of your selected product is: {DisplayAndCollectPrices.Price} and the percentage installment is {percentage * 100}%");
                    Console.WriteLine("The Amount of recurring payment is: {0:C}, the remaining money is: {2:C}, and the start date and time: {1}", DisplayAndCollectPrices.Price * percentage, dateOfPurchase, newPrice);
                    Console.WriteLine("Your next payment is in: " + DateTime.Now.AddSeconds(5));
                    newPrice = newPrice - deductibleAmount;
                    Thread.Sleep(5000);
                    Console.Clear();
                    user.AccBalance = user.AccBalance - deductibleAmount;
                    user.AccBalance = user.AccBalance + UserCheck.salary;
;
                }
            }
            else
            {
                Console.WriteLine("OOPS!! There is no payment plan for you at this time, Kindly buy in full or send us an email \n info@stephenshops.com");
            }

        }

    }
}
