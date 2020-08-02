using System;



namespace Lab_5._2
{
    class RandomPlayer : Player
    {
        private static Random rand = new Random(); // Class that allows you to get a random number
        public override Roshambo GenerateRoshambo() // Class method that will randomly select and return from the Roshambo enum
        {
            int Roshambo_num = rand.Next(3); // created a int variable that randomly select from 0-2
            Roshambo randomRoshambo = (Roshambo)Roshambo_num; // Created a Roshambo variable that picks a random enum from the enum Roshambo class

            return randomRoshambo; // Retursn a randomly selected enum (0-2)
        }
    }
}
