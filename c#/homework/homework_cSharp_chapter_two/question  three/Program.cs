using System;
using System.Linq;
namespace question__three
{

    class Program
    {
        static void inputArr(out int numOfElement, out int[] arr)
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

            arr = new Int32[numOfElement];
            for (int i = 0; i < numOfElement; i++)
            {
                Console.WriteLine("please enter the {0} rd element = ", i);
                arr[i] = int.Parse(Console.ReadLine());

            }



        }
        static void displayArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(" element the {0} rd is = {1} ", i, arr[i]);
            }

        }
        static void sortUpAcsending(int[] arr)
        {
            Console.WriteLine("array after sort is");
            Array.Sort(arr);
            displayArr(arr);
        }
        static void sortDownAcsending(int[] arr)
        {
            Console.WriteLine("array after sort reverse is");

            Array.Sort(arr);
            Array.Reverse(arr);
            displayArr(arr);


        }
        static void searchXInArray(int[] arr)
        {
            int minNum = 0;
            int maxNum = arr.Length - 1;
            int x;
            Console.WriteLine("input x for search X in  Array");
            x = Int32.Parse(Console.ReadLine());
            Array.Sort(arr);
            while (minNum <= maxNum)  
            {
                int mid = (minNum + maxNum) / 2;
                if(minNum+1 == maxNum)
                {
                    Console.WriteLine("there are no element in array");
                    break;
                }
                if (x == arr[mid])
                {
                    Console.WriteLine("The search X index = {0} and value = {1} ",mid, arr[mid]);
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
        static void searchMaxMinInArray(int[] arr)
        {
            int max = arr.Max();
            int min = arr.Min();
            Console.WriteLine("the large element in the array is = " + max);
            Console.WriteLine("the min element in the array is = " + min);
        }
        static void sumAllElementInArray(int[] arr)
        {
            int sum = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine("sum all element in array is = " + sum);
        }
        static void countOddNumberInArray(int[] arr)
        {
            int countOdd = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] % 2 != 0)
                {
                  countOdd += 1;
                }
            }
            Console.WriteLine("count odd element in array is = " + countOdd);

        }
        static bool checkPrime(int value)
        {
            bool result =false;
            if (value <= 2 && value > 0)
            {
                result =  true;
            }
            else
            {
                for(int i = 2; i < value; i++)
                {
                    if(value % 2 == 0)
                    {
                        result =  false;
                    }
                    else
                    {
                       result=  true;
                    }
                }
                }

            
        return result;
            
        }
        static void countPrimeInArray(int[] arr)
        {
            int sum = 0;
             for(int i = 0; i < arr.Length; i++)
            {
                if(checkPrime(arr[i]) == true)
                {
                    sum += 1;

                }
            }
            Console.WriteLine("the prime number in array is = " + sum);
        }


        static void Main(string[] args)
        {
            int numOfElement = 0;
            int[] arr;

            // enter and display array 
            inputArr(out numOfElement, out arr);
            displayArr(arr);

            //sort up acsending array
            sortUpAcsending(arr);

            //sort down acsending array
            sortDownAcsending(arr);

            // search x in array
            searchXInArray(arr);

         // search max min in array
            searchMaxMinInArray(arr);

            //calculate sum all element in array
            sumAllElementInArray(arr);

            //count odd number in array
            countOddNumberInArray(arr);

            // count prime in array
            countPrimeInArray(arr);

        }
    }
}
