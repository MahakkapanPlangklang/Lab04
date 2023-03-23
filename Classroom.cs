using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04
{
    public class Classroom
    {
        private string name;
        List<Person> persons = new List<Person>();
        private int ageSum = 0;
        private Person min = null;
        private Person max = null;


        public Classroom(string name) 
        {
            this.name = name;
        }

        public void addperson2Class(Person p) 
        {
            this.persons.Add(p);
            this.ageSum += p.getAge();

            if (max == null || p.getGPA() > max.getGPA())
            {
                this.max = p;
            }
            if (min == null || p.getGPA() < min.getGPA())
            {
                this.min = p;
            }










        }

        public string showallpersoninclass()    
        {
            string result = "";
            foreach (Person p in this.persons) 
            {
                result += p.getName() + "\r\n";
            }
            return result; 
        }
        public int totalAge()
        {

            int result = 0;
            foreach (Person p in this.persons)
            {

                result += +p.getAge();

            }
            return result;
        }

        public double avggpa()
        {
            double result = 0;
            int a = 0;
            foreach (Person p in this.persons)
            {
                
                result = (result+p.getGPA());
                a = a + 1;
            }
            result= result/a;
            return result;
        }
 
        public string NMinGPA()
        {
            return this.min.getName();
        }
        public double MinGPA()
        {
            if (min == null)
            {
                return 0; 
            }
            return this.min.getGPA();
        }
        public string NMaxGPA()
        {
            return this.max.getName();
        }
        public double MaxGPA()
        {
            if (max == null)
            {
                return 0; // 
            }
            return this.max.getGPA();
        }
        public int getPersonCount()
        {
            return this.persons.Count;
        }
        public int getAgeSumaryOfThisClass()
        {
            return this.ageSum;
        }
        public double getAgeAverage()
        {
            return this.ageSum / this.persons.Count;
        }
        public double GPAAverage()
        {
            double _avg = 0.0;
            foreach (Person p in this.persons)
            {
                _avg += p.getGPA();
            }
            return _avg / this.persons.Count;
        }
    }
}
