using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Lab04
{
    public partial class Form1 : Form
    {
        Classroom classroom;
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
            this.AVG.Text = this.classroom.GPAAverage().ToString();
            this.Min.Text = this.classroom.MinGPA().ToString();
            this.Max.Text = this.classroom.MaxGPA().ToString();
            this.NMax.Text = this.classroom.NMaxGPA().ToString();
            this.NMin.Text = this.classroom.NMinGPA().ToString();
           







            this.Name.Text = "";
            this.by.Text = "";
            this.GPA.Text = "";



        }

        
    }
}