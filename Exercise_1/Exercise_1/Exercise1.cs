using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input an integer to reverse and add:");
            int N = Convert.ToInt32(Console.ReadLine());

            int RN = 0, SN = 0; //RN stands for reversed number and SN for sum of number

            while (N > 0)
            {

                int digit = N % 10;  //Retrieve remainder of N
                RN = RN * 10 + digit; //Multiply remainder by 10
                SN += digit; //
                N /= 10;

            }

            Console.WriteLine("Reversed integer: {0}", RN);
            Console.WriteLine("Sum of integer: {0}", SN);

            /////
           
        }
    }
}
