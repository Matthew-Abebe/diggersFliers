using System;
using System.Collections.Generic;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Parakeet ParakeetInst = new Parakeet();

            ParakeetInst.Fly();

            Earthworm EarthwormInst = new Earthworm();

            EarthwormInst.Dig();

            Terrapin TerrapinInst = new Terrapin();

            TerrapinInst.Swim();

            Rattlesnake RattlesnakeInst = new Rattlesnake();

            RattlesnakeInst.doSurface();

            Mice MiceInst = new Mice();

            MiceInst.doSurface();

            Ant AntInst = new Ant();

            AntInst.Dig();

            Fish FishInst = new Fish();

            FishInst.Swim();

            Gerbil GerbilInst = new Gerbil();

            GerbilInst.Dig();


        }
    }
}

//create instance in main method
//call the method on parakeet
//make list that holds the interfaces. the list parameters will be interfaces