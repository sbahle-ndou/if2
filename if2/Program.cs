﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(getMax(2, 10));

            int getMax(int num1, int num2)  
            {
                if (num1 > num2)
                {
                    return num1;
                }
                else
                {
                    return num2;
                }
               

            }
            Console.ReadLine();
        }
    }
}
