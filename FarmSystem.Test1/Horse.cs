using System;

namespace FarmSystem.Test1
{
    class Horse : Animal
    {

        public override void Talk()
        {
            Console.WriteLine("Horse says neigh!");
        }

        public void Run()
        {
            Console.WriteLine("Horse is running");
        }

        public override void ProduceMilk()
        {
        }

    }
}