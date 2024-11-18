using System;

namespace AdventureGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the 'Adventure Generator'!");
            Console.WriteLine("You are the hero of this story. Make your choices and see where fate takes you.");
            Console.WriteLine();

       
            Console.WriteLine("You stand at a crossroads. In front of you are three paths:");
            Console.WriteLine("1. Dark forest");
            Console.WriteLine("2. Bright road");
            Console.WriteLine("3. Mysterious cave");
            Console.Write("Where will you go? Enter the number: ");
            string choice = Console.ReadLine();

           
            switch (choice)
            {
                case "1":
                    DarkForest();
                    break;
                case "2":
                    BrightRoad();
                    break;
                case "3":
                    MysteriousCave();
                    break;
                default:
                    Console.WriteLine("You didn’t make a choice, so fate decided for you. You stayed in place...");
                    break;
            }

            Console.WriteLine("\nThe adventure is over! Thank you for playing!");
            Console.ReadLine();
        }

      
        static void DarkForest()
        {
            Console.WriteLine("\nYou enter a dark forest. It seems endless.");
            Console.WriteLine("On your path, you see a huge bear!");
            Console.WriteLine("1. Run away");
            Console.WriteLine("2. Try to tame the bear");
            Console.Write("Your choice: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("You run with all your might and escape! But your heart is pounding like crazy.");
            }
            else if (choice == "2")
            {
                Console.WriteLine("You offer food with an outstretched hand. The bear looks at you... and becomes your friend!");
            }
            else
            {
                Console.WriteLine("You freeze in place, and the bear just walks away, leaving you alone.");
            }
        }

       
        static void BrightRoad()
        {
            Console.WriteLine("\nYou walk along a bright road. Birds are singing, the sun is shining.");
            Console.WriteLine("But on your path, you see a huge chest.");
            Console.WriteLine("1. Open the chest");
            Console.WriteLine("2. Ignore the chest");
            Console.Write("Your choice: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("You open the chest and find treasure! You're rich!");
            }
            else if (choice == "2")
            {
                Console.WriteLine("You walk past it, thinking it might be a trap. Smart move!");
            }
            else
            {
                Console.WriteLine("You think for too long, and the chest disappears. It was probably magic.");
            }
        }
  
        static void MysteriousCave()
        {
            Console.WriteLine("\nYou enter a mysterious cave. It’s dark and cool inside.");
            Console.WriteLine("Suddenly, you hear a strange sound.");
            Console.WriteLine("1. Investigate the source of the sound");
            Console.WriteLine("2. Leave the cave");
            Console.Write("Your choice: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("You find an ancient artifact! But someone is watching you...");
            }
            else if (choice == "2")
            {
                Console.WriteLine("You decide not to take risks and leave the cave. Better safe than sorry!");
            }
            else
            {
                Console.WriteLine("You stand still, and the darkness in the cave seems to grow thicker...");
            }
        }
    }
}
