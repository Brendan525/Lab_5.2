using System;

namespace Lab_5._2
{

    class Program
    {
        static void Main(string[] args)
        {
            PlayGame();
        }

        public static void PlayGame()
        {
            Rock rockplayer = new Rock(); // Rock object call rockplayer
            RandomPlayer rand = new RandomPlayer(); // RandomPlayer object called rand
            string inputname, opponent;
        

            Console.WriteLine("Welcome to Rock Paper Scissors!");

            Console.WriteLine("Enter your name: ");

            inputname = Console.ReadLine();
            HumanPlayer player = new HumanPlayer(inputname); // HimanPlayer object called player

            while (true) // While true, run this code
            {
                Console.WriteLine($"Would you like to play against TheJets or TheSharks (J/S)");

                opponent = Console.ReadLine().ToUpper();

                if (opponent == "J")
                {
                    AgainstRockPlayer(ref player, ref rockplayer, ref inputname); // Calls method that plays against the Rock CPU
                }
                else if (opponent == "S")
                {
                    AgainstRandomPlayer(ref player, ref rand, ref inputname); // Calls method that plays against the RandomPlayer CPU
                }
                else
                {
                    Console.WriteLine("Invalid option");
                    continue;
                }

                Console.WriteLine("Would you like to continue? (Y/N)");

                string continueInput = Console.ReadLine().ToUpper();

                if (continueInput == "Y")
                {
                    continue;
                }
                else if (continueInput == "N")
                {
                    Console.WriteLine("Thanks for playing");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter (Y/N");
                }

            }
        }

        public static void AgainstRockPlayer(ref HumanPlayer player, ref Rock rockplayer, ref string inputname)

        {
            Roshambo userinput = player.GenerateRoshambo(); // Saves the users input into another variable

            if (userinput == Roshambo.Rock)
            {
                Console.WriteLine($"{inputname}: {userinput}"); // Prints the users input
                Console.WriteLine($"TheJets: {rockplayer.GenerateRoshambo()}"); // Prints Rock
                Console.WriteLine("It's a Tie");
            }
            else if (userinput == Roshambo.Scissors)
            {
                Console.WriteLine($"{inputname}: {userinput}");
                Console.WriteLine($"TheJets: {rockplayer.GenerateRoshambo()}"); // Prints Rock
                Console.WriteLine("TheJets win");           
                //Console.WriteLine($"CPU Wins: {cpuWin++}"); Got to add back to the agruements
            }
            else
            {
                Console.WriteLine($"{inputname}: {userinput}");
                Console.WriteLine($"TheJets: {rockplayer.GenerateRoshambo()}"); // Prints Rock
                Console.WriteLine($"{inputname} wins.");
                //Console.WriteLine($"{inputname}'s Wins: {cpuWin++}"); Got to add back to the agruements
            }
        } 

        public static void AgainstRandomPlayer(ref HumanPlayer player, ref RandomPlayer rand, ref string inputname)
        {
            Roshambo userinput = player.GenerateRoshambo(); // Saves the users input into another variable              
            Roshambo randomInput = rand.GenerateRoshambo();
          

            if (userinput == randomInput)
            {
                Console.WriteLine($"{inputname}: {userinput}");
                Console.WriteLine($"TheSharks: {randomInput}");
                Console.WriteLine("It's a Tie");
            }
            else if (userinput == Roshambo.Rock && randomInput == Roshambo.Paper || userinput == Roshambo.Paper && randomInput == Roshambo.Scissors || userinput == Roshambo.Scissors && randomInput == Roshambo.Rock)
            {
                Console.WriteLine($"{inputname}: {userinput}");
                Console.WriteLine($"TheSharks: {randomInput}");
                Console.WriteLine("TheSharks win");
                
            }
            else
            {
                Console.WriteLine($"{inputname}: {userinput}");
                Console.WriteLine($"TheSharks: {randomInput}");
                Console.WriteLine($"{inputname} wins");
  
            }
        }
    }
}
