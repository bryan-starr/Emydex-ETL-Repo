using System;

namespace FarmSystem.Test1
{
    class Hen : Animal
    {

        public override void Talk()
        {
            Console.WriteLine("Hen say CLUCKAAAAAWWWWK!");
        }

        public void Run()
        {
            Console.WriteLine("Hen is running");
        }

        public override void ProduceMilk()
        {
        }
    }
}