using System;
using System.Collections.Generic;

namespace Animals
{
    public class Terrapin : ISwimming
    {

        public string Swimming { get; set; }

        public void Swim()
        {
            Console.WriteLine("Animal is now swimming");
        }
    }
}
