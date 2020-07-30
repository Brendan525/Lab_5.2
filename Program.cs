using System;

namespace Lab_5._2
{

    enum Roshambo
    {
        Rock,
        Paper,
        Scissors
    }

    abstract class Player
    {
        public Roshambo theroshambo { get; set; }

        public abstract Roshambo GenerateRoshambo();
    }

    class Rock : Player
    {
        public override Roshambo GenerateRoshambo()
        {
            Roshambo Rock = Roshambo.Rock;
            
            return Rock;
        }
    }

    class RandomPlayer : Player
    {
        private static Random rand = new Random();
        public override Roshambo GenerateRoshambo()
        {
            int Roshambo_num = rand.Next(3);
            Roshambo randomRoshambo = (Roshambo)Roshambo_num;

            return randomRoshambo;
        }
    }

    class HumanPlayer : Player
    {
        public override Roshambo GenerateRoshambo()
        {
            Console.WriteLine("Rock, Paper, or Scissors (R/P/S): "); // Question

            while (true)
            {
                string rps = Console.ReadLine().ToUpper(); // Asks for input

                if (rps == "R")
                {
                    return Roshambo.Rock;
                }
                else if (rps == "P")
                {
                    return Roshambo.Paper;
                }
                else if (rps == "S")
                {
                    return Roshambo.Scissors;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter (R/P/S)");
                    continue;
                }
            }
            
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Rock rockplayer = new Rock();
            HumanPlayer player = new HumanPlayer();
            RandomPlayer rand = new RandomPlayer();
            string inputname, versus;

            Console.WriteLine("Welcome to Rock Paper Scissors!");

            Console.WriteLine("Enter your name: ");

            inputname = Console.ReadLine();
            while (true)
            {
                Console.WriteLine($"Would you like to play against TheJets or TheSharks (J/S)");

                versus = Console.ReadLine().ToUpper();

                if (versus == "J")
                {
                    Roshambo userinput = player.GenerateRoshambo(); // Saves the users input into another variable

                    Console.WriteLine($"TheJets: {rockplayer.GenerateRoshambo()}"); // Prints Rock

                    if (userinput == Roshambo.Rock)
                    {
                        Console.WriteLine("It's a Tie");
                    }
                    else if (userinput == Roshambo.Scissors)
                    {
                        Console.WriteLine("TheJets win");
                    }
                    else
                    {
                        Console.WriteLine($"{inputname} wins.");
                    }
                }
                else if (versus == "S")
                {
                    Roshambo userInput = player.GenerateRoshambo(); // Saves the users input into another variable    
                    Console.WriteLine($"{inputname}: {userInput}"); // Prints Rock

                    Roshambo randomInput = rand.GenerateRoshambo();
                    Console.WriteLine($"TheSharks: {randomInput}");

                    WinLoseDraw(ref inputname, userInput, randomInput);
                }
                else
                {
                    Console.WriteLine("Invalid option");
                    continue;
                }
            }
        }

        public static void WinLoseDraw(ref string inputname, Roshambo userInput, Roshambo randomInput)
        {
            if (userInput == randomInput)
            {
                Console.WriteLine("It's a Tie");
            }
            else if (userInput == Roshambo.Rock && randomInput == Roshambo.Paper || userInput == Roshambo.Paper && randomInput == Roshambo.Scissors || userInput == Roshambo.Scissors && randomInput == Roshambo.Rock)
            {
                Console.WriteLine("TheSharks win");
            }
            else
            {
                Console.WriteLine($"{inputname} wins");
            }
        }
    }
}
