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

        public Classroom(string name) 
        {
            this.name = name;
        }

        public void addperson2Class(Person p) 
        {
            this.persons.Add(p);
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
        public double maxGPA()
        {
            double max = 0;
            foreach (Person p in this.persons)
            {

                if (max < double.Parse(p.getGPA().ToString()))
                {
                    max = double.Parse(p.getGPA().ToString());
                }

            }
            return max;
        }

        public double minGPA()
        {
            //double a= p.getGPA().ToString();
            double min = 0;
            foreach (Person p in this.persons)
            {

                if (min < double.Parse(p.getGPA().ToString()))
                {
                    min = double.Parse(p.getGPA().ToString());
                }

            }
            return min;
        }
        public string maxp()
        {
            string resultp = "";
            double maxp = 0;
            foreach (Person p in this.persons)
            {

                if (maxp >= double.Parse(p.getGPA().ToString()))
                {
                    //maxp = double.Parse(p.getGPA().ToString());
                    resultp = p.getName().ToString();
                }
                
            }
            return resultp;
        }
    }
}
