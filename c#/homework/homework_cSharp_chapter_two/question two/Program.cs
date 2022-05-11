using System;

namespace question_two
{
    class Program
    {
        static double factorial(double x)
        {
            if (x == 0)
            {
                return 1;
            }
            else
            {
              return x * factorial(x - 1);
            }
        }
        static void s1(int x)
        {
            double result = 0;
            for(double i = 1; i <= x; i++)
            {
                result += 1 / i;
            }
            Console.WriteLine("The result of the calculation s(x) (1) is = " + result);
        }
        static void s2(int x)
        {
            double result = 0;
            for (double i = 1; i <= x; i++)
            {
                result += 1 / factorial(i);
            }
            Console.WriteLine("The result of the calculation s(x) (2) is = " + result);
        }
        static void Main(string[] args)
        {
            bool testX;
            int x;
            Console.WriteLine("input value x");
            do
            {

                testX = Int32.TryParse(Console.ReadLine(), out x);


                if (testX == true && x > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("invalid value please re-enter");
                }


            } while (true);
            s1(x);
            s2(x);

        }
    }
}
