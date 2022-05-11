using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork_2
{

    class Cadre
    {
        private String idCode;
        private String name;
        private String position;
        private int birthYear;
        private double factorWare;

        public Cadre()
        {
            idCode = "";
            name = " ";
            position = "";
            birthYear = 1;
            factorWare = 0;

        }

        public Cadre(string idCode, string name, string position, int birthYear, double factorWare)
        {
            this.idCode = idCode;
            this.name = name;
            this.position = position;
            this.birthYear = birthYear;
            this.factorWare = factorWare;
        }
        public void display()
        {
            Console.WriteLine(name + ' ' + idCode + " " + position + " " + birthYear + " " + factorWare);
        }
        public void enterDataForArray()
        {
            Console.WriteLine("enter name cadre is : ");
            name = Console.ReadLine();
            Console.WriteLine("enter id code for cadre is : ");
            idCode = Console.ReadLine();
            Console.WriteLine("enter position for cadre is : ");
            position = Console.ReadLine();
            Console.WriteLine("enter birth year for cadre is :");
            birthYear = int.Parse(Console.ReadLine());
            Console.WriteLine("enter factorWare for cadre is :");
            factorWare = double.Parse(Console.ReadLine());
        }

    }


}
