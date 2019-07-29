using System;
using System.Collections.Generic;

namespace Animals
{
    public class Fish : ISwimming
    {

        public string Swimming { get; set; }

        public void Swim()
        {
            Console.WriteLine("Animal is now swimming");
        }
    }
}
