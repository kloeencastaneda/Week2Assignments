using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the number of rows for M: ");
            int M = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the number of colums for N: ");
            int N = Convert.ToInt32(Console.ReadLine());

            int[,] arr = new int[M, N]; //makes 2D array (or 3D I cant remember)

            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < M; i++) //for the rows
            {
                for (int j = 0; j < N; j++) //for the columns
                {
                    Console.WriteLine($"Enter the element at row {i + 1}, column {j + 1}: ");
                    arr[i, j] = Convert.ToInt32(Console.ReadLine()); //
                }
            }

            int SRS = int.MaxValue; //SRS stands for smallest row sum
            int SRI = -1;

            for (int i = 0; i < M; i++)
            {
                int rowSum = 0;
                for (int j = 0; j < N; j++)
                {
                    rowSum += arr[i, j];
                }
                if (rowSum < SRS)
                {
                    SRS = rowSum;
                    SRI = i;
                }
            }

            Console.WriteLine("The row with the smallest sum is row {0}", SRI + 1);
        }
    }
}