﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä_15
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.Write("Anna korkeus >");
            int ans, i, j, k, x, z;
            ans = int.Parse(Console.ReadLine());
            int l = ans - 2;
            for (i = 1; i <= l; i++)
            {
                for (j = 1; j < ans - i + 1; j++)
                {
                    Console.Write(" ");
                }
                for (k = 1; k <= i; k++)
                {
                    Console.Write("*");
                    Console.Write(" ");
                }
                if (l == i)
                {
                    Console.WriteLine();
                    for (x = 0; x <= 1; x++)
                    {
                        for (z = 0; z < i + 1; z++)
                        {
                            Console.Write(" ");
                        }
                        Console.Write("*");
                        Console.WriteLine();
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
