using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit_11
{
    class Persion
    {
        string name;
        string birthDay;
        string homeTown;

       
        public string Name { get => name; set => name = value; }
        public string BirthDay { get => birthDay; set => birthDay = value; }
        public string HomeTown { get => homeTown; set => homeTown = value; } 
        public Persion(string name, string birthDay, string homeTown)
        {
            this.name = name;
            this.birthDay = birthDay;
            this.homeTown = homeTown;
        }
        public Persion()
        {
            name = " ";
            birthDay = "";
            homeTown = " ";
        }

        public void enterDataPersion()
        {
            Console.WriteLine("enter field name");
            name = Console.ReadLine();
            Console.WriteLine("enter field birth day");
            birthDay = Console.ReadLine();
            Console.WriteLine("enter field home town");
            homeTown = Console.ReadLine();
        }
        public void display()
        {
            Console.WriteLine("information persion is" + name + " " + birthDay + " " + homeTown);
        } 
        public void speak()
        {
            Console.WriteLine("hhahahaha");
        }
    }
}
