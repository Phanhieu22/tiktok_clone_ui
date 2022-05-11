using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit_9
{
    class MyCat :Animal
    {
        private string color;

        public MyCat(string name,double height , double weight, string color) : base(name, height, weight)
        {
            this.color = color;

        }
        public MyCat()
        {
            color = "";
        }
        public void inputDataCat()
        {
            base.inputData();
            Console.WriteLine("enter color for my cat");
            color = Console.ReadLine();
        }  public void displayData()
        {
            Console.WriteLine(Name + " " + color + " " + Height + " " + Weight);
        }
        // sử dụng hàm tạo tại lớp cơ sở 

    }
}
