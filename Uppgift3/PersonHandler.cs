using System;
using System.Collections.Generic;
using System.Text;

namespace PersonAndAnimal
{
    class PersonHandler 
    {
        

        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
            return;
        }

        public Person CreatePerson(int age, string fname, string lname, double height, double weight) {
            Person per = new Person();
            per.Age = age ;
            per.FName = fname;
            per.LName = lname;
            per.Height = height;
            per.Weight = weight;
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
                    p.FName = name;
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
                    p.LName = lastname;
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
                    p.Age = age;
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
                    p.Height = height;
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
                    p.Weight = weight;
                    success = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error! in the main page", e.Message);

                }
            } while (success);

            util.writeLine($"Person name is: {p.FName} {p.LName}, Age is: {p.Age}, Height is: {p.Height} and weight is: {p.Weight}");

            return p;
        }


    }
}
