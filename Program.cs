using System;

namespace Lab_5._2
{

    enum Roshambo
    {
        Rock,
        Paper,
        Scissors
    }

    class Program
    {
        static void Main(string[] args)
        {
            PlayGame();
        }

        public static void PlayGame()
        {
            Rock rockplayer = new Rock();
            HumanPlayer player = new HumanPlayer();
            RandomPlayer rand = new RandomPlayer();

           

            string inputname, versus;
            //int userWin = 0;
            //int cpuWin = 0;
            bool again = true;

            Console.WriteLine("Welcome to Rock Paper Scissors!");

            Console.WriteLine("Enter your name: ");

            inputname = Console.ReadLine();
            while (again)
            {
                Console.WriteLine($"Would you like to play against TheJets or TheSharks (J/S)");

                versus = Console.ReadLine().ToUpper();

                if (versus == "J")
                {
                    AgainstRockPlayer(ref player, ref rockplayer, ref inputname, ref again);
                }
                else if (versus == "S")
                {
                    AgainstRandomPlayer(ref player, ref rand, ref inputname, ref again);
                }
                else
                {
                    Console.WriteLine("Invalid option");
                    continue;
                }
            }
        }




        public static void AgainstRockPlayer(ref HumanPlayer player, ref Rock rockplayer, ref string inputname, ref bool again)

        {
            Roshambo userinput = player.GenerateRoshambo(); // Saves the users input into another variable

            if (userinput == Roshambo.Rock)
            {
                Console.WriteLine($"{inputname}: {userinput}");
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

            Console.WriteLine("Would you like to play again? (Y/N)");

            string input = Console.ReadLine().ToUpper();

            if (input == "Y")
            {
                again = true;
            }
            else if (input == "N")
            {
                Console.WriteLine("Thanks for playing");
                again = false;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter (Y/N)");
                again = false;
            }

        }

        public static void AgainstRandomPlayer(ref HumanPlayer player, ref RandomPlayer rand, ref string inputname, ref bool again)
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
                CConsole.WriteLine($"{inputname}: {userinput}");
                Console.WriteLine($"TheSharks: {randomInput}");
                Console.WriteLine($"{inputname} wins");
  
            }

            Console.WriteLine("Would you like to play again? (Y/N)");

            string input = Console.ReadLine().ToUpper();

            if (input == "Y")
            {
                again = true; ;
            }
            else if (input == "N")
            {
                Console.WriteLine("Thanks for playing");
                again = false; ;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter (Y/N)");
                again = false; ;
            }

            //WinLoseDraw(ref inputname, userInput, randomInput, ref cpuWin, ref userWin);
        }

        
    }
}
