using System;
using System.Collections.Generic;

namespace Animals
{
    public class Mice : ISurface
    {

        public string Surface { get; set; }

        public void doSurface()
        {
            Console.WriteLine("Animal is now doing surface");
        }
    }
}
