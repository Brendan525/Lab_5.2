using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5._2
{
    abstract class Player
    {
        public string Name { get; set; }

        public Roshambo theroshambo { get; set; }

        public abstract Roshambo GenerateRoshambo();
    }
}
