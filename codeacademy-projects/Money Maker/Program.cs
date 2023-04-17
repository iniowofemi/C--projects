using System;

namespace MoneyMaker
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //dotnet run
            Console.WriteLine("Welcome to Money Maker!");

            //get amount to convert from user
            Console.WriteLine("How much money would you like to convert? ");
            string amountString = Console.ReadLine();

            //convert amount to a number
            double amount = Convert.ToDouble(amountString);
            Console.WriteLine(amount + " cents is equal to...");

            //define coin values
            int gold = 10;
            int silver = 5;
            int bronze = 1;

            double goldCoins = Math.Floor(amount / gold);
            double remainingOne = amount % gold;

            double silverCoins = Math.Floor(remainingOne / silver);
            double remainingTwo = remainingOne % silver;

            double bronzeCoins = remainingTwo;

            Console.WriteLine($"{goldCoins} gold coins, {silverCoins} silver coins and {bronzeCoins} bronze coins");

        }
    }
}
