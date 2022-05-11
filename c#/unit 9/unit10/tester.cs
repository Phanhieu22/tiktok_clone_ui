using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit_10
{
    class tester
    {
        static public void enterForListTeacher(out int n , out Teacher []listTeacher)
        {
            Console.WriteLine("enter num of element for array");
            n = int.Parse(Console.ReadLine());
            listTeacher = new Teacher[n];
            for (int i = 0; i < n; i++)
            {
                Teacher x = new Teacher();
                x.enterDataTeacher();
                listTeacher[i] = x;
            }
        }
        static public void displayListTeacher(Teacher[] listTeacher)
        {
            for (int i = 0; i < listTeacher.Length; i++)
            {
                
                listTeacher[i].display();
            }

        }
        static void Main(String[] args)
        {
            Teacher [] listTeacher;
            int n = 0;

            enterForListTeacher(out n , out listTeacher);
            displayListTeacher(listTeacher);
        }
    }
}
