using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork_2
{
        class tester
        {
            static void inputDataForArray(out int n, out Cadre[] listCadre)
        {
            Console.WriteLine("enter numbers the listCadre = ");
            n = int.Parse(Console.ReadLine());
            listCadre = new Cadre[n];
            Console.WriteLine("value of n is = " + n);
            for(int i =0; i< n; i++)
            {
                Console.WriteLine("cadre the {0}th is");
                Cadre x = new Cadre();
                x.enterDataForArray();
                listCadre[i] = x;

            }
        }
        static void displayArr(Cadre[] listCadre)
        {
            for(int i = 0; i < listCadre.Length; i++)
            {
                listCadre[i].display();

            }
        }
        static void Main(String[] args)
        {

            int n;
            Cadre[] listCadre;
            inputDataForArray(out n , out listCadre);

            displayArr(listCadre);

        }
    }
}
