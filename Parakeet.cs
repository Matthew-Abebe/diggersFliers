using System;
using System.Collections.Generic;

namespace Animals
{
    public class Parakeet : IFlying
    {

        public string Flying { get; set; }

        public void Fly()
        {
            Console.WriteLine("Animal is now flying");
        }
    }
}
