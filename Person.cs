using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    public class Person
    {
        private int age;
        private int BirthYear;
        private string name;
        private double GPA;


            public Person(string name, int bYear, double gPA)
        {
            this.name = name;
            this.BirthYear = bYear;
            this.age = 2565 - bYear;
            this.GPA = gPA;
        }

        public int getAge() 
        { 
            return this.age; 
        }
        public string getName() 
        { 
            return this.name;
        }
        public int getBT() 
        {
            return this.BirthYear;
        }
        public double getGPA()
        {
            return this.GPA;
        }
        

    }
}
