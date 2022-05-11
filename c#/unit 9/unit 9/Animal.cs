using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit_9
{
    class Animal
    {
        private string name;
        private double height;
        private double weight;



        public string Name { get => name; set => name = value; }
        public double Height { get => height; set => height = value; }
        public double Weight { get => weight; set => weight = value; }

        public Animal()
        {
            name = "";
            height = 0;
            weight = 0;
        }
        public Animal(string name, double height, double weight)
        {
            this.name = name;
            this.height = height;
            this.weight = weight;
        }
        public void getNameAnimal()
        {
            Console.WriteLine("an animal named is " + name);
        }
        public void inputData()
        {
            Console.WriteLine("input name for animal");
            name = Console.ReadLine();
            Console.WriteLine("enter height for animal ");
            height = double.Parse(Console.ReadLine());
            Console.WriteLine("enter weight for animal ");
            weight = double.Parse(Console.ReadLine());

        }
    }
}
