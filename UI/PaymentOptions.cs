namespace InstalmentsProject.UI
{
    internal class PaymentOptions
    {
        public static double premium = 0.20D; public static double gold = 0.3D; public static double executive = 0.5D;

        private static double MySelection { get; set; }
        public static double PaymentOption()
        {
            string lines = Utility.Lines();
            Console.Clear();
            Utility.DisplayCompany(lines);
            Console.WriteLine("");
            int myOption = 0;
            int numTries = 3;

            while (myOption < 1 || myOption > 3)
            {
                try
                {
                    if (numTries != 0)
                    {
                        if (numTries == 1)
                        {
                            Utility.ErrorMessage("\t\tThis is your last try!!!");
                        }
                        Utility.DisplayCompany($"\t\t\tYou {numTries} numbers of tries remaining");
                        Console.WriteLine("Kindly Select your payment Options by selecting the number");
                        Console.WriteLine("1. Premium (Pay 20% every 1 minutes)");
                        Console.WriteLine("2. Gold (Pay 30% every 1 minutes)");
                        Console.WriteLine("3. Executive (Pay 50% every 1 minutes)");
                        myOption = Convert.ToInt32(Console.ReadLine());

                        numTries--;
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

            if (myOption == 1)
            {
                MySelection = premium;
            }
            else if (myOption == 2)
            {
                MySelection = gold;
            }
            else if (myOption == 3)
            {
                MySelection = executive;
            }

            return MySelection;
        }
    }
}
