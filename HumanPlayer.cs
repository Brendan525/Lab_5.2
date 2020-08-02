using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5._2
{
    class HumanPlayer : Player
    {

        public HumanPlayer(string thename) // Class instance
        {
            Name = thename;
        }

        public override Roshambo GenerateRoshambo() // Class method that returns the users input
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
}
