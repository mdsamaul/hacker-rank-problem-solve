using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hacker_rank
{

    //https://www.hackerrank.com/challenges/diagonal-difference/problem?isFullScreen=true
    //1 2 3
    //4 5 6
    //9 8 9
    //output |15-17|=2
    internal class DiSum
    {
        public void s() {
            int n;
            Console.Write("enter the  number : ");
            n = int.Parse(Console.ReadLine());
            int[,] arr = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{i},{j} : ");
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.Write("Your Result is : ", dSum(arr, n));
        }

        public static int dSum(int[,] ar, int n)
        {
            int res1 = 0;
            int res2 = 0;
            int result = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        //Console.Write($"{i} , {j} = {ar[i,j]}");
                        res1 += ar[i, j];
                    }
                    if (i + j == n - 1)
                    {
                        //Console.Write($"{i} , {j} = {ar[i, j]} \n");
                        res2 += ar[i, j];
                    }
                }

                //Console.WriteLine();
            }
            //Console.WriteLine($"{res1},{res2}");

            result = Math.Abs(res1 - res2);
            return result;
        }

    }


}
    
