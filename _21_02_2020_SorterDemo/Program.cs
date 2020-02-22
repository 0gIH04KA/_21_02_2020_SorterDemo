using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_02_2020_SorterDemo
{
    class Program
    {
        static Random random = new Random();

        static void Main(string[] args)
        {
            int[] arrInput = new int[20000];

            for (int i = 0; i < arrInput.Length; i++)
            {
                arrInput[i] = random.Next(-1000, 1000);
            }


            Console.ReadKey();
        }
    }
}
