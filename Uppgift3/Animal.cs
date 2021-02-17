using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift3
{

    abstract class Animal
    {

        // In this class we should put the new attribute that will be used in for all the animals we have


        public string AnimalName { get; set; }
        public int AnimalAge { get; set; }
        public double AnimalWeight { get; set; }

        public abstract string DoSound();

        public virtual string Stats()
        {
            return $"The Animal name is:{AnimalName}, age is{AnimalAge}, weight is:{AnimalWeight}, ";
        }



        public Animal(string name, int age, double weight)
        {
            AnimalName = name;
            AnimalAge = age;
            AnimalWeight = weight;
        }

    }


    class Dog : Animal
    {
        public string Specialty { get; set; }
        public Dog(string name, int age, double weight, string specialty) : base(name, age, weight)
        {
            Specialty = "very loyal";
        }
        // class dog is subclass to class animal, so class dog can take from animal but not the other way around
        public void newMethod() { }
        public override string DoSound() => "Dog say: Woff Woff\n";
        public override string Stats()
        {
            return base.Stats() + $"specialty is: {Specialty}";
        }


    }

    class Horse : Animal
    {
        public string Specialty { get; set; }
        public Horse(string name, int age, double weight, string specialty) : base(name, age, weight)
        {

            Specialty = specialty;
        }

        public override string DoSound() => "Horse say: HAHAHA\n";

        public override string Stats() => base.Stats() + $"specialty is: {Specialty}";


    }

    class Hedgehog : Animal
    {
        public string Specialty { get; set; }

        //"Have many spikes!"
        public Hedgehog(string name, int age, double weight, string specialty) : base(name, age, weight)
        {

            Specialty = specialty;

        }

        public override string DoSound() => "Hedgehog does't do any sounds!\n";


        public override string Stats() => base.Stats() + $"specialty is: {Specialty}";
    }

    class Worm : Animal
    {
        private string specialty;

        public string Specialty { get ; set ; }

        public Worm(string name, int age, double weight, string specialty) : base(name, age, weight)
        {

            Specialty = specialty;

        }
        public override string DoSound() => "Worm say: Don't stop the music!\n";


        public override string Stats() => base.Stats() + $"specialty is: {Specialty}";
       
    }

    class Bird : Animal
    {

        //In this class we can add the new attribu that will be used in all the birds subclass
        public string Specialty { get; set; }


        public Bird(string name, int age, double weight, string specialty) : base(name, age, weight)
        {

            Specialty = specialty;

        }

        public override string DoSound() => "Bird say: Quack, Quack!\n";


        public override string Stats() => base.Stats() + $"specialty is: {Specialty}";

    }

    class Wolf : Animal
    {

        public string Specialty { get ; set ; }
        public Wolf(string name, int age, double weight, string specialty) : base(name, age, weight)
        {
         
            Specialty = specialty;
        }

        public override string DoSound() => "Wolf say: Waooooooo!!\n";


        public override string Stats() => base.Stats() + $"specialty is: {Specialty}";
       
    }



    class Pelican : Bird
    {

        public Pelican(string name, int age, double weight, string specialty) : base(name, age, weight, specialty)
        {
        }

    }

    class Flamingo : Bird
    {
        public Flamingo(string name, int age, double weight, string specialty) : base(name, age, weight, specialty)
        {
        }

    }

    class Swan : Bird
    {
        public Swan(string name, int age, double weight, string specialty) : base(name, age, weight, specialty)
        {
        }

    }

    public interface IPersons
    {
        string Talk();

    }

    class WolfMan : Wolf, IPersons
    {
        public WolfMan(string name, int age, double weight, string specialty) : base(name, age, weight, specialty)
        {
    
        }
        public string Talk() => "I AM A WOLFMAN";
    }
}
