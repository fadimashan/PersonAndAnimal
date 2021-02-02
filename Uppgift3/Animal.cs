using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift3
{

    //interface IAnimal
    //{
    //    string DoSound();
    //}
    abstract class Animal
    {

        // In this class we should put the new attribute that will be used in for all the animals we have
        //private string name;
        //private double weight;
        //private int age;

        public string AnimalName { get; set; }
        public int AnimalAge { get; set; }
        public double AnimalWeight { get; set; }

        public abstract string DoSound();

        public virtual string Stats()
        {
            return $"The Animal name is:{AnimalName}, age is{AnimalAge}, weight is:{AnimalWeight}, ";
        }



        public Animal(string name, int age,double weight)
        {
            AnimalName = name;
            AnimalAge = age;
            AnimalWeight = weight;
        }

    }


    class Dog : Animal
    {
        //private string specialty;
        //public string Loyalty { get => specialty; set => specialty = "Very loyal"; }
        public string Loyalty { get; set; }
        public Dog(string name, int age, double weight, string loyalty) : base(name, age, weight)
        {
            //AnimalName = name;
            //AnimalAge = age;
            //AnimalWeight = weight;
            Loyalty = "very loyal";
        }
        // class dog is subclass to class animal, so class dog can take from animal but not the other way around
        public void newMethod() { }
        public override string DoSound() => "Dog say: Woff Woff\n";
        public override string Stats()
        {
            return base.Stats() + $"specialty is: {Loyalty}";
        }


    }

    class Horse : Animal
    {
        private string specialty;
        public string Fast { get=> specialty; set=> specialty = "Very fast"; }
        public Horse(string name, int age, double weight) : base(name, age, weight)
        {

            //AnimalName = name;
            //AnimalAge = age;
            //AnimalWeight = weight;
            Fast = specialty;

        }

        public override string DoSound() => "Horse say: HAHAHA\n";
       
        public override string Stats()
        {  
            return $"The Animal name is:{AnimalName}, age is{AnimalAge}, weight is:{AnimalWeight}, specialty is: {Fast}";
        }

    }

    class Hedgehog : Animal
    {
        private string specialty;
        public string NrOfSpikes { get => specialty; set => specialty = "Have many spikes!"; }

        public Hedgehog(string name, int age, double weight) : base(name, age, weight)
        {
            AnimalName = name;
            AnimalAge = age;
            AnimalWeight = weight;
            NrOfSpikes = specialty;

        }

        public override string DoSound() => "Hedgehog does't do any sounds!\n";


        public override string Stats()
        {
            return $"The Animal name is:{AnimalName}, age is{AnimalAge}, weight is:{AnimalWeight}, specialty is: {NrOfSpikes}";
        }
    }

    class Worm : Animal
    {
        private string specialty;

        public string IsPoisonous { get => specialty; set => specialty = "Is Poisonous!"; }

        public Worm(string name, int age, double weight) : base(name, age, weight)
        {
            AnimalName = name;
            AnimalAge = age;
            AnimalWeight = weight;
            IsPoisonous = specialty;

        }
        public override string DoSound() => "Worm say: Don't stop the music!\n";


        public override string Stats()
        {
            return $"The Animal name is:{AnimalName}, age is{AnimalAge}, weight is:{AnimalWeight}, specialty is: {IsPoisonous}";
        }
    }

    class Bird : Animal
    {

        //In this class we can add the new attribu that will be used in all the birds subclass
        private string specialty;
        public string Fly { get => specialty; set => specialty = "Fly!"; }
       

        public Bird(string name, int age, double weight) : base(name, age, weight)
        {
            AnimalName = name;
            AnimalAge = age;
            AnimalWeight = weight;
            Fly = specialty;

        }

        public override string DoSound() => "Bird say: Quack, Quack!\n";


        public override string Stats()
        {
            return $"The Animal name is:{AnimalName}, age is{AnimalAge}, weight is:{AnimalWeight}, specialty is: {Fly}";
        }
    }

    class Wolf : Animal
    {
        private string specialty;

        public string Wild { get => specialty; set => specialty = "Wild!" ; }
        public Wolf(string name, int age, double weight) : base(name, age, weight)
        {
            AnimalName = name;
            AnimalAge = age;
            AnimalWeight = weight;
            Wild = specialty;
        }

        public override string DoSound() => "Wolf say: Waooooooo!!\n";


        public override string Stats()
        {
            return $"The Animal name is:{AnimalName}, age is{AnimalAge}, weight is:{AnimalWeight}, specialty is: {Wild}";
        }
    }



    class Pelican : Bird
    {
        private string specialty;
        public string LikeWater { get => specialty; set => specialty = "Pelican likes water!"; }

        public Pelican(string name, int age, double weight) : base(name, age, weight)
        {
            AnimalName = name;
            AnimalAge = age;
            AnimalWeight = weight;
            LikeWater = specialty;
        }

    }

    class Flamingo : Bird
    {
        private string specialty;
        public string FlyHeigh { get => specialty; set => specialty = "Fly heigh!"; }

        public Flamingo(string name, int age, double weight) : base(name, age, weight)
        {
            AnimalName = name;
            AnimalAge = age;
            AnimalWeight = weight;
            FlyHeigh = specialty;
        }

    }

    class Swan : Bird
    {
        private string specialty;
        public string Breeds { get => specialty; set => specialty = "Bleaches!"; }

        public Swan (string name, int age, double weight) : base(name, age, weight)
        {
            AnimalName = name;
            AnimalAge = age;
            AnimalWeight = weight;
            Breeds = specialty;
        }

    }

    public interface IPersons
    { 
        string Talk();

    }

    class WolfMan : Wolf, IPersons
    {
        private string specialty;
        public string Changeable { get => specialty; set => specialty = "Changeable!"; }
        public WolfMan (string name, int age, double weight ) : base(name, age, weight)
        {
            AnimalName = name;
            AnimalAge = age;
            AnimalWeight = weight;
            Changeable = specialty;
        }


        public string Talk()
        {
            return "I AM A WOLFMAN";
        }
        public override string DoSound() => "Wolf say: Waooooooo!!";

    }
}
