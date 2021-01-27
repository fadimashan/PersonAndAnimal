using NLog;
using System;
using System.Collections.Generic;

namespace Uppgift3
{
    class Program
    {


        static void Main(string[] args)
        {
            Util util = new Util();
            PersonHandler personHandler = new PersonHandler();
            List<Person> personList = new List<Person>();
            List<PersonHandler> phList = new List<PersonHandler>();
            var _logger = LogManager.GetLogger("test for loger");
            string name = "";
            string lastname = "";
            int age = 0;
            double height = 0;
            double weight = 0;


            Person p = new Person(name, lastname, age, height, weight);

            //using the new method in the class PersonHandler to create a new persone 

            personList.Add(personHandler.CreatePerson(22, "Weoe", "ghggg", 17, 818));
            var p2 = personHandler.CreatePerson(22, "Rody", "Makein", 180, 69);
            personList.Add(p2);
            var p3 = personHandler.CreatePerson(27, "Fadi", "HHHHH", 10, 9);
            personList.Add(p3);

            
            foreach (Person per in personList)
            {
                
                util.writeLine($"Person name is: {per.FName1} {per.LName1}, Age is: {per.Age1}, Height is: {per.Height1} and weight is: {per.Weight1}");
                
            }

            bool loop = true;
            
            util.writeLine("choose an option");
            while (loop)
            {
                util.writeLine("1 for add new person \n2 for print all persons\n3 for edit persone details");
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
                            util.writeLine($"{i+1}- Person name is: {personList[i].FName1} {personList[i].LName1}, Age is: {personList[i].Age1}, Height is: {personList[i].Height1} and weight is: {personList[i].Weight1}");
                        }

                        break;


                    case 3:
                        util.writeLine("chose which user you want to edit, by number");
                        for (int i = 0; i < personList.Count; i++)
                        {
                            util.writeLine($"{i + 1}- Person name is: {personList[i].FName1} {personList[i].LName1}, Age is: {personList[i].Age1}, Height is: {personList[i].Height1} and weight is: {personList[i].Weight1}");
                        }
                        var userNumber = util.read();
                        var output = 0;

                        personHandler.edit(personList[util.paresToInt(userNumber, output) - 1]);

                        break;

                    case 4:
                        loop = false;
                        break;


                }

            }


            // change the age using the new class PersonHandler
            util.writeLine("Enter new age for the person");
            var newAge = int.Parse(Console.ReadLine());

            personHandler.SetAge(p, newAge);
            util.writeLine($"Person name is: {p.FName1} {p.LName1}, the new Age is: {p.Age1}");

        }




    }
}
