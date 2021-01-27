using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift3
{
    class Person
    {

        Util util = new Util();


        private int Age;
        private string FName;
        private string LName;
        private double Height;
        private double Weight;

        public int Age1
        {
            get => Age;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("Error!");
                }
                else
                {
                    Age = value;
                }
            }
        }


        public string FName1 
        { 
            get=> FName;
            set { 
                if (value.Length <= 2)
                {
                    throw new ArgumentNullException("Error!");

                }
                else
                {
                    FName = value;
                }
            } 
        }

        public string LName1
        {
            get => LName;
            set
            {
                if (value.Length <= 2)
                {
                    throw new ArgumentNullException("Error!");

                }
                else
                {
                    LName = value;
                }
            }
        }

        public double Weight1
        {
            get => Weight;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("Error!");

                }
                else
                {
                    Weight = value;
                }
            }
        }

        public double Height1
        {
            get => Height;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("Error!");

                }
                else
                {
                    Height = value;
                }
            }
        }

        public Person(string fName, string lName, int age, double height, double weight)
        {

            FName = fName;
            LName = lName;
            Age = age;
            Height = height;
            Weight = weight;
        }

        public Person()
        {
        }
    }


}
