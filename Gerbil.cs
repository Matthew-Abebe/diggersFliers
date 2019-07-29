using System;
using System.Collections.Generic;

namespace Animals
{
    public class Gerbil : IDigging
    {

        public string Digging { get; set; }

        public void Dig()
        {
            Console.WriteLine("Animal is now digging");
        }
    }
}
