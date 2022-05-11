using System;

namespace homework_cSharp_chapter_two
{
    class Program
    {
        static void fx1( double x)
        { 
            double result;
            if(x < -1)
            {
                result = x + Math.Sin(x);
            }
            else
            {
                result = Math.Sqrt(x + 1);
               
            }
            Console.WriteLine("The result of the calculation f(x) (1) is = " + result);

        }
        static void fx2(double x)
        {
            double result;
            if( x<= 1)
            {
                result = (2 * Math.Pow(x, 2)) + 3;
            }
            else
            {
                if(x >= 2)
                {
                    result = (5 * x) + 1;

                }
                else
                {
                    result = 2 * Math.Cos(x) - Math.Exp(x);
                }
            }
            Console.WriteLine("The result of the calculation f(X) (2) is = " + result);
        }
        static void Main(string[] args)
        {
            // question one f(x) (1)
            bool testX;
            double x;
            Console.WriteLine("input value x");
            do
            {

                testX = double.TryParse(Console.ReadLine(), out x);


                if(testX == true)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("invalid value please re-enter");
                }
                

            } while (true);

            fx1(x);
            fx2(x);

        }
    }
}
