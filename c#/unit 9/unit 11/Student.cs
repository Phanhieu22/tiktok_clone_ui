using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit_11
{
    class Student : Persion
    {

        string idStudent;
        string nameClass;
        public string IdStudent { get => idStudent; set => idStudent = value; }
        public string NameClass { get => nameClass; set => nameClass = value; }
        public Student(string idStudent, string nameClass, string name, string birthDay, string homeTown) : base(name, birthDay, homeTown)
        {
            this.idStudent = idStudent;
            this.nameClass = nameClass;
        }

        public Student()
        {
            idStudent = " ";
            nameClass = " ";
        }

        public void enterDataForStudent()
        {
            base.enterDataPersion();
            Console.WriteLine("enter field idStudent");
            idStudent = Console.ReadLine();
            Console.WriteLine("enter field class name");
            nameClass = Console.ReadLine();
        }
        public void displayInformationStudent()
        {
            Console.WriteLine("information student is + id student : {0} name class :  {1} name : {2} birthday : {3} home town : {4}",idStudent , nameClass , Name, BirthDay , HomeTown);

        }

    }
}
