using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5._2
{
    class Rock : Player
    {
        public override Roshambo GenerateRoshambo()
        {
            Roshambo Rock = Roshambo.Rock;

            return Rock;
        }
    }
}
