using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Lab04
{
    public partial class Form1 : Form
    {
        Classroom classroom;
        Person p;
        public Form1()
        {
            InitializeComponent();
            classroom = new Classroom("OOP");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = this.Name.Text;
            string BirthYear = this.by.Text;
            string gpa = this.GPA.Text;
            int iYear = Int32.Parse(BirthYear);
            double g = Double.Parse(gpa);
            //
            Person person = new Person(name,iYear,g);
            this.classroom.addperson2Class(person);

            this.namelist.Text =this.classroom.showallpersoninclass();
            this.total.Text = this.classroom.totalAge().ToString();
            //this.Max.Text = this.classroom.maxgpa().ToString();
          //  double a = this.classroom.avggpa();
           // double b = Convert.To(this.classroom.avggpa());
            this.AVG.Text = this.classroom.avggpa().ToString();
            this.Max.Text = this.classroom.maxGPA().ToString();
            this.Min.Text = this.classroom.minGPA().ToString();
            this.NMax.Text = this.classroom.maxp().ToString();
            //this.NMin.Text = this.classroom.minGPA().ToString();







            this.Name.Text = "";
            this.by.Text = "";
            this.GPA.Text = "";



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}