using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit_10
{
    class TeacherCntt:Teacher
    {
        string organnizationGroup;

        public string OrgannizationGroup { get => organnizationGroup; set => organnizationGroup = value; }

        public TeacherCntt(string organnizationGroup , string nameTeacher, string homeTown, double coefficientsSalary):base( nameTeacher,  homeTown,  coefficientsSalary)
        {
           
            this.OrgannizationGroup = organnizationGroup;
        }
        public TeacherCntt()
        {
            organnizationGroup = " ";
        }
        public void enterTeacherCntt()
        {
            base.enterDataTeacher();
            Console.WriteLine("enter field organnixation group");
            organnizationGroup = Console.ReadLine();
           
        }
        public void displayTeacherCntt()
        {
            base.display();
            Console.WriteLine("organnization group" + organnizationGroup);


        }

    }
}
