using System;
using Cau01;
using Cau02;
using Cau03;


namespace PTTKTT_BUOI02_2033210951_HuynhThanhTam
{
    class Program
    {
        public static void PrintArray(int[] A)
        {
            foreach (var num in A)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] array = { 2, 4, 7, 10, 13, 18, 22 };
            int[] a = { 7, 4, 12, 10, 3 };

            int key = 2;
            int n = a.Length;
            int index = BinarySearch.Binary_Search(array, array.Length, key);

            if (index != -1)
                Console.WriteLine("Found {0} at index {1}", key, index);
            else
                Console.WriteLine("{0} not found in the array", key);



            MergeSort.Merge_Sort(a, 0, n - 1);
            Console.WriteLine("Array after sorting:");
            PrintArray(a);


            long X = 2112;
            long Y = 1707;
            int N = 4;
            long result =BigNumberMulti.Big_Number_Multi(X, Y, N);
            Console.WriteLine("Result of {0} * {1} = {2}", X, Y, result);
            Console.ReadLine();
        }
     
    }
}
