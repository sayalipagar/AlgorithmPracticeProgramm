using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProgramm
{
    internal class InsertionSort
    {
        public void Insertionsort1()
        {
            int[] arr = { 78, 55, 45, 98, 13 };
            int temp;
            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i + 1] == arr[j])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            Console.WriteLine("sorted Array");
            foreach (int ele in arr)
            {
                Console.WriteLine(ele + " ");
            }
        }
    }
}

