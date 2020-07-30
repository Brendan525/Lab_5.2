using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5._2
{
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
}
