using System;

namespace c_shap_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Boolean testA, testB, testC;
            // nhập 3 số 
            Console.WriteLine("nhap a");
            testA = double.TryParse(Console.ReadLine(), out a);
             Console.WriteLine("nhap b");
            testB = double.TryParse(Console.ReadLine(), out b);
            Console.WriteLine("nhap c");
            testC = double.TryParse(Console.ReadLine(), out c);
            if(a > 0 && b>0 && c> 0)
            {
                double max1, max2;
                max1 = a > b ? a : b;
                max2 = max1 > c ? max1 : c;
                Console.WriteLine("gia tri lon nhat cua ban la {0}", max2);
            }
            else
            {
                Console.WriteLine("gia tri nhap vao khong hop le");

            }

        }
    }
}
