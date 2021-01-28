using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift3
{
    class PersonHandler 
    {
        

        public void SetAge(Person pers, int age)
        {
            pers.Age1 = age;
            return;
        }

        public int Age { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }


        public Person CreatePerson(int age, string fname, string lname, double height, double weight) {
            Person per = new Person();
            Age = age;
            Name = fname;
            Lastname = lname;
            Height = height;
            Weight = weight;
            per.Age1 = age ;
            per.FName1 = fname;
            per.LName1 = lname;
            per.Height1 = height;
            per.Weight1 = weight;
            return per;
        }




        public Person addnewPerson()
        {
            Person p = new Person();
            return edit(p);
           
        }




        public Person edit(Person p)
        {
            Util util = new Util();
            bool success = true;

            do
            {
                try
                {
                    success = true;
                    util.writeLine("Enter a new name");
                    string name = util.read();
                    p.FName1 = name;
                    success = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error! in the name", e.Message);

                }

            } while (success);


            do
            {
                try
                {
                    success = true;
                    util.writeLine("Enter a new lastname");
                    string lastname = Console.ReadLine();
                    p.LName1 = lastname;
                    success = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error! in the last name", e.Message);
                }
            } while (success);


            do
            {
                try
                {
                    success = true;
                    util.writeLine("Enter a new age");
                    int age = int.Parse(Console.ReadLine());
                    p.Age1 = age;
                    success = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error! in the Age", e.Message);
                }
            } while (success);

            do
            {
                try
                {
                    success = true;
                    util.writeLine("Enter a new height");
                    var height = double.Parse(Console.ReadLine());
                    p.Height1 = height;
                    success = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error! in the height", e.Message);
                }
            } while (success);
            do
            {
                try
                {
                    success = true;
                    util.writeLine("Enter a new weight");
                    var weight = double.Parse(Console.ReadLine());
                    p.Weight1 = weight;
                    success = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error! in the main page", e.Message);

                }
            } while (success);

            util.writeLine($"Person name is: {p.FName1} {p.LName1}, Age is: {p.Age1}, Height is: {p.Height1} and weight is: {p.Weight1}");

            return p;
        }


    }
}
