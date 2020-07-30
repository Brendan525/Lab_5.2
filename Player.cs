using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5._2
{
    abstract class Player
    {
        public Roshambo theroshambo { get; set; }

        public abstract Roshambo GenerateRoshambo();
    }
}
