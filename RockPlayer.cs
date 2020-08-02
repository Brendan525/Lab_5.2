using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5._2
{
    class Rock : Player
    {
        public override Roshambo GenerateRoshambo() // Class method that has the Rock player always select rock
        {
            Roshambo Rock = Roshambo.Rock;

            return Rock;
        }
    }
}
