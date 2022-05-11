using System;
using System.Linq;
namespace question__three
{

    class Program
    {
        static void inputArr(out int numOfElement, out double[] arr)
        {
            bool testNum;
            Console.WriteLine("enter num of element");
            do
            {
                testNum = Int32.TryParse(Console.ReadLine(), out numOfElement);

                if (testNum == true)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("invalid num please re-enter ");
                }
            }
            while (true);

            arr = new double[numOfElement];
            for (int i = 0; i < numOfElement; i++)
            {
                Console.WriteLine("please enter the {0} rd element = ", i);
                arr[i] = double.Parse(Console.ReadLine());

            }



        }
        static void displayArr(double[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(" element the {0} rd is = {1} ", i, arr[i]);
            }

        }
        static void searchXInArray(double[] arr)
        {
            int minNum = 0;
            int maxNum = arr.Length - 1;
            double x;
            Console.WriteLine("input x for search X in  Array");
            x = double.Parse(Console.ReadLine());
            Array.Sort(arr);
            while (minNum <= maxNum)
            {
                int mid = (minNum + maxNum) / 2;
                if (x == arr[mid])
                {
                    Console.WriteLine("The search x index={0} and value = {1}",mid, arr[mid]);
                    break;
                }
                else if (x < arr[mid])
                {
                    maxNum = mid;
                }
                else
                {
                    minNum = mid;
                }
            }


        }
        static void searchMaxMinInArray(double[] arr)
        {
            double max = arr.Max();
            double min = arr.Min();
            Console.WriteLine("the large element in the array is = " + max);
            Console.WriteLine("the min element in the array is = " + min);
        }
        static void averageAllElementInArray(double[] arr)
        {
            double sum = 0;
            double average = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            average = sum / arr.Length;
            Console.WriteLine("average all element in array is = " + average);
        }
        static void listPositiveNumberInArray(double[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    Console.WriteLine("number positive in array is element {0} rd value is = {1} ", i, arr[i]);
                }
            }
        }
        static void sumOfNegativeNum(double[] arr)
        {
            double sumNegative = 0;
            for (int i = 0; i < arr.Length; i++)
            {
            if (arr[i] < 0)
            {
                sumNegative += arr[i];
            }
            }
            Console.WriteLine("sum of negative number in array is = " + sumNegative);
                
        }
        static void Main(string[] args)
        {
            int numOfElement = 0;
            double[] arr;

            // enter and display array 
            inputArr(out numOfElement, out arr);
            displayArr(arr);
            // search x in array
            searchXInArray(arr);

            // search max min in array
            searchMaxMinInArray(arr);

            //list positive number in array
            listPositiveNumberInArray(arr);

            // sum of negative number in array
            sumOfNegativeNum(arr);

            //calculate average all element in array
            averageAllElementInArray(arr);
        }
    }
}
