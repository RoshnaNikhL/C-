using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScoreArray
{
   
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int i = 0;
            int j = 0;
            int temp = 0;
            int[] arr = new int[n];
            Console.WriteLine("Enter number of elements in array");
            n = int.Parse(Console.ReadLine());
                
            Console.WriteLine("Enter elements of array");
            for(i=0;i<n;i++)
            {
                arr[i] = int.Parse((Console.ReadLine()));
            }

            for(i=0;i<n-1;i++)
            {
                for(j=0;j<n-1;j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }




                }
            }

            Console.ReadLine();

        }
    }
}
