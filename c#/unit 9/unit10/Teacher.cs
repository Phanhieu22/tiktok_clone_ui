using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit_10
{
      class Teacher
    {
        string nameTeacher;
        string homeTown;
        double coefficientsSalary;

        public Teacher(string nameTeacher, string homeTown, double coefficientsSalary)
        {
            this.nameTeacher = nameTeacher;
            this.homeTown = homeTown;
            this.coefficientsSalary = coefficientsSalary;
        }

        public string NameTeacher { get => nameTeacher; set => nameTeacher = value; }
        public string HomeTown { get => homeTown; set => homeTown = value; }
        public double CoefficientsSalary { get => coefficientsSalary; set => coefficientsSalary = value; }

        public Teacher()
        {
            NameTeacher = " ";
            HomeTown = "";
            CoefficientsSalary = 0;
        }
        public void enterDataTeacher()
        {

            Console.WriteLine("enter field name teacher");
            nameTeacher = Console.ReadLine();
            Console.WriteLine("enter field home town");
            homeTown = Console.ReadLine();
            Console.WriteLine("enter field coefficents lasary");
            coefficientsSalary = double.Parse(Console.ReadLine());
        }
        public void display()
        {
            Console.WriteLine("information teacher is " + "name = " + nameTeacher + "homeTown is " + homeTown + "coefficients lasary" + coefficientsSalary);
        }
    }
}
