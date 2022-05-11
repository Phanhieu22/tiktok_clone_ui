using System;

namespace libraly_student
{
    public class Student
    {
        string name;
        int age;
        string gender;
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Gender { get => gender; set => gender = value; }

        public Student(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }
        public Student()
        {
            name = " ";
            age = 0;
            gender = " ";
            ;
        }
        public void display()
        {
            Console.WriteLine("information student is " + name + " " + age + " " + gender);
        }
        public void inputData()
        {
            Console.WriteLine("enter field name");
            name = Console.ReadLine();
            Console.WriteLine("enter field age");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("enter field gender");
            gender = Console.ReadLine();


        }

    }
}
