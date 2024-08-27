using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hacker_rank
{
    internal class Staircase
    {
        public void Pattan() {
            int size = 0;
            Console.Write("enter the size : ");
            size =int.Parse(Console.ReadLine());
            int[,] arr= new int[size, size];
            for (int i = 1; i <= size; i++)
            {
                for (int j = 0; j < size-i; j++)
                {
                   
                    Console.Write(" ");
                }
                for (int j = 0; j <i; j++)
                {

                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }

        
    }
}
