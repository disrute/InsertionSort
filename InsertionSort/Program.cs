using System;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 25, 21, 17, 29, 13, 2 };

            for(int i = 0; i < arr.Length; i++)
            {
                int temp = arr[i];
                int j = i;

                while (j > 0 && temp < arr[j - 1])
                {
                    arr[j] = arr[j - 1];
                    j--;
                }

                arr[j] = temp;
            }

            foreach (var i in arr)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
