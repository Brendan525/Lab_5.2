using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5._2
{
    abstract class Player // Abstract class where an instance or object cannot be created
    {
        private string name; // Private name field

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public Roshambo theroshambo { get; set; }

        public abstract Roshambo GenerateRoshambo();
    }
}
