using System;

namespace FarmSystem.Test1
{
    public abstract class Animal : IMilkableAnimal
    {
        public abstract void Talk();

        public abstract void ProduceMilk();

        private string _id;
        private int _noOfLegs = 4;
        private string _animalName;


        public string Id
        {
            get { return _id; }
            set
            {
                _id = value;
            }
        }

        public int NoOfLegs
        {
            get
            {
                return _noOfLegs;
            }
            set
            {
                _noOfLegs = 4;
            }
        }

        public string AnimalName
        {
            get { return _animalName; }
            set
            {
                _animalName = value;
            }
        }

    }
}
