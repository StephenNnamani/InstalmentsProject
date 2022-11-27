using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InstalmentsProject.UI;

namespace InstalmentsProject.Operations
{
    internal class CountdownInstalments
    {
        public static DateTime dateOfPurchase = DateTime.Now;

        public static void CountDownInstalments()
        {
            double price = DisplayAndCollectPrices.Products();
            double percentage = PaymentOptions.PaymentOption();
            double deductibleAmount = price * percentage;
            double newPrice = price;
            while (newPrice! > 0)
            {
                Console.Clear();
                Utility.Lines();
                Utility.DisplayCompany($"The Price of your selected product is: {price} and the percentage installment is {percentage * 100}%");
                Console.WriteLine("The Amount of recurring payment is: {0:C}, the remaining money is: {2:C}, and the start date and time: {1}", price * percentage, dateOfPurchase, newPrice);
                Console.WriteLine("Your next payment is in: " + DateTime.Now.AddSeconds(5));
                newPrice = newPrice - deductibleAmount;
                Thread.Sleep(5000);
                Console.Clear();
            }

        }

    }
}
