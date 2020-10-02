using System;

namespace TextadventureMadlib
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a Madlib, enter the following...");
            // User input for a name
            Console.WriteLine("Enter a name: ");
            string name = Console.ReadLine();

            // User input for first adjective
            Console.WriteLine("Enter a adjective: ");
            string adj = Console.ReadLine();

            // User input for second adjective
            Console.WriteLine("Enter a second adjective: ");
            string adj2 = Console.ReadLine();

            // User input for a place
            Console.WriteLine("Enter a place: ");
            string place = Console.ReadLine();

            // User input for an animal
            Console.WriteLine("Enter an animal: ");
            string animal = Console.ReadLine();

            // User input for a food
            Console.WriteLine("Enter a food: ");
            string food = Console.ReadLine();

            // User input for a Tv show
            Console.WriteLine("Enter a tv show: ");
            string tv = Console.ReadLine();

            // Story template
            string story = $"One day {name} woke up feeling {adj}. " +
                $"Today is going to be a {adj2} day! " +
                $"{name} went to the {place} and saw a {animal}." +
                $" The {animal} was eating a {food}!" +
                $" {name} went back home to watch {tv} and then {name} went to sleep.";

            // print the story
            Console.WriteLine(story);



        }
    }
}
