using System;

namespace FarmSystem.Test1
{
    public class EmydexFarmSystem
    {
        private Animal[] Animals = new Animal[4];

        //TEST 1
        public void Enter(Animal animal)
        {
            Console.WriteLine("{0} has entered the Emydex farm", animal.AnimalName);
            for (int i = 0; i < Animals.Length; i++)
            {
                if (Animals[i] is null)
                {
                    Animals[i] = animal;
                    break;
                }
            }
        }
     
        //TEST 2
        public void MakeNoise()
        {
            foreach (Animal a in Animals)
            {
                a.Talk();
            }
        }

        //TEST 3
        public void MilkAnimals()
        {
            foreach (Animal a in Animals)
            {
                a.ProduceMilk();
            }
        }

        //TEST 4
        public void ReleaseAllAnimals()
        {
            for (int i = 0; i < Animals.Length; i++)
            {
                Console.WriteLine("{0} has left the Emydex farm", Animals[i].AnimalName);
                Array.Clear(Animals, i, 1);
            }

            Console.WriteLine("Emydex Farm is now empty.");
        }
    }
}