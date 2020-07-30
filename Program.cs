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

        public override Roshambo GenerateRoshambo(HumanPlayer player)
        {
            HumanPlayer pl
            
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            //string inputname;
            //string versus;
            //Console.WriteLine("Welcome to Rock Paper Scissors!");

            //Console.WriteLine("Enter your nam: ");

            //inputname = Console.ReadLine();

            //Console.WriteLine($"Hello {inputname}, Would you like to play against TheJets or TheSharks (j/s)");

            //versus = Console.ReadLine().ToLower();

            //if (versus == "j")
            //{
                
            //}
            //else if(versus == "s")
            //{

            //}
            //else if (versus != "j" | versus != "s")
            //{
            //    Console.WriteLine("Invalid option");
            //}

            Rock rockplayer = new Rock();

            Console.WriteLine(rockplayer.GenerateRoshambo()); // Prints Rock

            RandomPlayer randomPlayer = new RandomPlayer();

            Console.WriteLine(randomPlayer.GenerateRoshambo()); // Randomly prints Rock, Paper, or Scissors

            


        }
    }
}
