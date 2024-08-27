using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hacker_rank
{
    internal class Mini_Max_Sum
    {
        public void MMSum() {
            int size = 0;
            Console.Write("enter the size : ");
            size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write($"insert position {i} : ");
                arr[i]= int.Parse(Console.ReadLine());
            }

            Array.Sort(arr);
            int result = 0;
            for (int i = 0; i < size-1; i++) {
                result += arr[i];
            }
            Console.Write("{0} ",result);
            Array.Sort(arr, (a,b) => b.CompareTo(a));
            result = 0;
            for (int i = 0; i < size - 1; i++)
            {
                result += arr[i];
            }
            Console.WriteLine(result);
        }
    }
}
