using System;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            This program is a mad lib game...
            Author: Ini...
            */


            // Let the user know that the program is starting:


            // Give the Mad Lib a title:
            string title = "Story Example";

            Console.WriteLine(title);
            // Define user input and variables:
            Console.WriteLine("Mad Libs has started");

            Console.WriteLine("Enter a name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter an adjective (e.g. blue, soft, round)");
            string adjectiveOne = Console.ReadLine();
            Console.WriteLine("Enter an adjective (e.g. blue, soft, round)");
            string adjectiveTwo = Console.ReadLine();
            Console.WriteLine("Enter an adjective (e.g. blue, soft, round)");
            string adjectiveThree = Console.ReadLine();

            Console.WriteLine("Enter a verb (e.g. sit, eat, sleep)");
            string verbOne = Console.ReadLine();

            Console.WriteLine("Enter a noun (e.g. girl, cabin, toaster)");
            string nounOne = Console.ReadLine();
            Console.WriteLine("Enter a noun (e.g. girl, cabin, toaster)");
            string nounTwo = Console.ReadLine();

            Console.WriteLine("Enter an animal");
            string animal = Console.ReadLine();

            Console.WriteLine("Enter a food");
            string food = Console.ReadLine();

            Console.WriteLine("Enter a fruit");
            string fruit = Console.ReadLine();

            Console.WriteLine("Enter a superhero");
            string superhero = Console.ReadLine();

            Console.WriteLine("Enter a country");
            string country = Console.ReadLine();

            Console.WriteLine("Enter a dessert");
            string dessert = Console.ReadLine();

            Console.WriteLine("Enter a year");
            string year = Console.ReadLine();
            // The template for the story:

            string story = $"This morning {name} woke up feeling {adjectiveOne}. 'It is going to be a {adjectiveTwo} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verbOne} to the rhythm of the {nounOne}, which made all the {fruit}s very {adjectiveThree}. Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {nounTwo}s ruled the world.";


            // Print the story:
            Console.WriteLine(story);

        }
    }
}
