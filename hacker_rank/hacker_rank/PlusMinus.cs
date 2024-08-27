using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hacker_rank
{
    //https://www.hackerrank.com/challenges/plus-minus/problem?isFullScreen=true
    internal class PlusMinus
    {
        public void pMinus()
        {
            //arr = [-4, 3, -9, 0, 4, 1]
            int n;
            Console.Write("enter the size : ");
            n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"position at {i} : ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            minusMinusOutput(arr);
        }
        public void minusMinusOutput(int[] ar)
        {
            int s = ar.Length;
            //int c = ar.Count();
            //Console.WriteLine(n);
            //Console.WriteLine(c);         //there are same Length and count()

            int p = 0;
            int n = 0;
            int z = 0;
            double result = 0.0;
            foreach (int item in ar)
            {
                //Console.WriteLine(item);
                if (item > 0)
                {
                    p++;
                }
                else if (item < 0)
                {
                    n++;
                }
                else
                {
                    z++;
                }

            }
           result= (double)p / s;
            Console.WriteLine(result.ToString("F6"));

            result = (double)n / s;
            Console.WriteLine(result.ToString("F6"));

            result = (double)z / s;
            Console.WriteLine(result.ToString("F6"));
        }
    }
}
