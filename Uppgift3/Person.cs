using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift3
{
    class Person
    {
        private int age;
        private string fName;
        private string lName;
        private double height;
        private double weight;

        public int Age
        {
            get => age;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("Error!");
                }
                else
                {
                    age = value;
                }
            }
        }


        public string FName
        { 
            get=> fName;
            set { 
                if (value.Length <= 2)
                {
                    throw new ArgumentNullException("Error!");

                }
                else
                {
                    fName = value;
                }
            } 
        }

        public string LName
        {
            get => lName;
            set
            {
                if (value.Length <= 2)
                {
                    throw new ArgumentNullException("Error!");
                }
                else
                {
                    lName = value;
                }
            }
        }

        public double Weight
        {
            get => weight;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("Error!");

                }
                else
                {
                    weight = value;
                }
            }
        }

        public double Height
        {
            get => height;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("Error!");

                }
                else
                {
                    height = value;
                }
            }
        }
    }

}
