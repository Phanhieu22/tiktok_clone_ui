using System;

namespace c_shap_2
{
    class Program
    {
        static void nhapmang(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("nhap a[{0}]=", i);// a[0]=
                a[i] = int.Parse(Console.ReadLine());// nhap so nguyen
            }
        }
        static void hienthi(int[] a, int n)
        {
            foreach (int x in a)
                Console.Write("{0}", x);
        }
        static void Main(string[] args)
        {
            //nhập 1 mảng sau đó hiển thị mảng, sau đó tính tổng các phần tử trong mảng
            // nhao
            int[] arr;/// khai bao dong thoi khoi gan gt
            //double[] b = new double[10];
            int n;
            Console.WriteLine("nhap kich thuoc mang");
            n = int.Parse(Console.ReadLine());
            arr = new int[n];// khoi gan mang tuong
            nhapmang( arr,  n);
            hienthi(arr, n);
            

            Console.ReadLine();
        }
    }
}
