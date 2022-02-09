using System;

namespace FarmSystem.Test1
{
    class Sheep : Animal
    {
       
        public override void Talk()
        {
            Console.WriteLine("Sheep says baa!");
        }
        
        public void Run()
        {
            Console.WriteLine("Sheep is running");
        }

        public override void ProduceMilk()
        {
        }
    }

}