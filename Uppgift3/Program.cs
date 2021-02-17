using NLog;
using System;
using System.Collections.Generic;

namespace PersonAndAnimal
{
    class Program
    {


        static void Main(string[] args)
        {
            Util util = new Util();
            PersonHandler personHandler = new PersonHandler();
            List<Person> personList = new List<Person>();
            NumericInputError numericInputError = new NumericInputError();
            TextInputError textInputError = new TextInputError();
            One firstMethod = new One();
            Two secondMethod = new Two();
            Three thirdMethod = new Three();
            List<UserError> userErrorsList = new List<UserError>() { 
            numericInputError, textInputError,firstMethod,secondMethod,thirdMethod
            };

            //using the new method in the class PersonHandler to create a new persone 

            personList.Add(personHandler.CreatePerson(22, "Weoe", "ghggg", 17, 818));
            var p2 = personHandler.CreatePerson(22, "Rody", "Makein", 180, 69);
            personList.Add(p2);
            var p3 = personHandler.CreatePerson(27, "Fadi", "HHHHH", 10, 9);
            personList.Add(p3);

            // Adding some animals to the Animal list
            Horse horse = new Horse("Horse", 2, 23,"Fast");
            Dog dog = new Dog("Dog", 2, 10, "Loyal");
            Dog dog2 = new Dog("Dog2", 12, 15, "Not very loyal");
            Hedgehog hedgehog = new Hedgehog("Hedgehog", 2, 7, "Spicky!");
            Worm worm = new Worm("Worm", 1, 0.001,"Slow!");
            Wolf wolf = new Wolf("Wolf", 23, 70,"Strong");
            Bird bird = new Bird("Bird", 1, 0.6,"Flay");
            Pelican pelican = new Pelican("Pelican", 5, 9,"Big beak");
            Flamingo flamingo = new Flamingo("Flamingo", 8, 16, "Long legs");
            Swan swan = new Swan("Swan", 12, 24,"Super white");
            WolfMan wolfMan = new WolfMan("WolfMan", 25, 90, "Changeable");
            List<Animal> listOfAnimal = new List<Animal>() {
                            horse,dog,hedgehog,worm,wolf,bird,pelican,flamingo,swan,wolfMan,dog2
                        };


            foreach (Person per in personList)
            {

                util.writeLine($"Person name is: {per.FName} {per.LName}, Age is: {per.Age}, Height is: {per.Height} and weight is: {per.Weight}");

            }

            bool loop = true;

            util.writeLine("choose an option");
            while (loop)
            {
                util.writeLine("\n1 for add new person \n2 for print all persons\n3 for edit persone details\n4 to Exit\n5 to get Animls states\n6 to print Dogs list\n7 to print out the UserError");
                var option = util.read();
                var num = 0;


                switch (util.paresToInt(option, num))
                {
                    case 1:
                        util.writeLine("Add new person");
                        var newPer = personHandler.addnewPerson();
                        personList.Add(newPer);
                        loop = true;
                        break;

                    case 2:
                        for (int i = 0; i < personList.Count; i++)
                        {
                            util.writeLine($"{i + 1}- Person name is: {personList[i].FName} {personList[i].LName}, Age is: {personList[i].Age}, Height is: {personList[i].Height} and weight is: {personList[i].Weight}");
                        }

                        break;


                    case 3:
                        util.writeLine("chose which user you want to edit, by number");
                        for (int i = 0; i < personList.Count; i++)
                        {
                            util.writeLine($"{i + 1}- Person name is: {personList[i].FName} {personList[i].LName}, Age is: {personList[i].Age}, Height is: {personList[i].Height} and weight is: {personList[i].Weight}");
                        }
                        var userNumber = util.read();
                        var output = 0;

                        personHandler.edit(personList[util.paresToInt(userNumber, output) - 1]);

                        // remove item 
                        //personList.RemoveAt(output-1);
                        break;

                    case 4:
                        loop = false;
                        break;

                    case 5:

                        foreach (Animal animal in listOfAnimal)
                        {
                            Console.WriteLine(animal.Stats());

                            if (animal is IPersons)
                            {
                                IPersons human = (IPersons)animal;
                                Console.WriteLine(human.Talk());
                            }

                            if (animal is Animal)
                            {
                                Console.WriteLine(animal.DoSound());

                            }

                        }
                        break;

                    case 6:
                        List<Dog> dogList = new List<Dog>();


                        foreach (Animal animal in listOfAnimal)
                        {
                            /*
                             * it's different instance and there is no direct relation between class Dog and class Horse
                            */
                            if (animal is Dog)
                            {
                                dogList.Add(animal as Dog);
                            }

                        }

                        foreach (Dog dogs in dogList)
                        {
                            Console.WriteLine(dogs.Stats());
                        }

                        /*  OR this way by using Animal class

                        List<Animal> dogsList = new List<Animal>();

                        foreach (Animal animal in listOfAnimal)
                        {
                            if (animal is Dog)
                            {
                                dogsList.Add(animal);
                            }

                        }
                        */

                        break;
                    case 7:

                        foreach (UserError error in userErrorsList) {

                            util.writeLine(error.UEMessage());
                        }

                        break;

                }

            }


            // change the age using the new class PersonHandler
            util.writeLine("Enter new age for the person");
            var newAge = int.Parse(Console.ReadLine());

            personHandler.SetAge(p2, newAge);
            util.writeLine($"Person name is: {p2.FName} {p2.LName}, the new Age is: {p2.Age}");

        }

    }
}
