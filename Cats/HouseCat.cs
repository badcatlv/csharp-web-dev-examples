﻿namespace Cats
{
    public class HouseCat : Cat
    {
        public string Name { get; set; }
        public string Species { get; } = "Felis catus";


        public HouseCat(string name, double weight) : base(weight)
        {
            Name = name;
        }

        // TODO: On this line, write a constructor that uses the no-arg constructor in the Cat class.
        public HouseCat(string name)
        {
            Name = name;
        }

        public bool IsSatisfied()
        {
            return !Hungry && !Tired;
        }

        public override string Noise()
        {
            return "Hello, my name is " + Name + "!";
        }

        public string Purr()
        {
            return "I'm a housecat";
        }
    }
}

