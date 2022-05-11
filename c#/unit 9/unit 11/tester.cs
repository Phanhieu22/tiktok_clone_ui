using System;

namespace unit_11
{
    class tester
    {
        static void enterDataForList(out int n, out Student[] listStudent)
        {
            bool testN;
            Console.WriteLine("number of elements in the list");
            n = int.Parse(Console.ReadLine());
            listStudent = new Student[n];

            for (int i = 0; i < n; i++)
            {
                Student x = new Student();
                x.enterDataForStudent();
                listStudent[i] = x;
            }
        }
        static void displayListStuden(Student[] listStudent)
        {
            for (int i = 0; i < listStudent.Length; i++)
            {
                Console.WriteLine("enter data for {0}th student" , i);
                listStudent[i].displayInformationStudent();
            }
        }
        static void Main(string[] args)
        {
            // Student[] listStudent;
            // int n =0 ;

            // enterDataForList(out n , out listStudent);
            // displayListStuden(listStudent);
            Persion hieu = new Persion("hieu", "24/11/2002", "tuyen quang");

            hieu.display();



        }
    }
}
