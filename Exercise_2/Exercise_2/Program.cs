using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter amount of integer elements in array: ");
            int N = Convert.ToInt32(Console.ReadLine());

            int[] arr = new

                int[N]; //N is now size of array
            Console.WriteLine("Enter the {0} elements of your array:\n", N);
            for (int i = 0; i < N; i++)  //Check index for integers
            {
                Console.Write("Element- {0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            int smallest = arr[0];
            int position = 0;

            for (int i = 1; i < N; i++)
            {
                if (arr[i] < smallest)
                {
                    smallest = arr[i];
                    position = i;
                }
            }

            Console.WriteLine("The smallest integer is: {0} ", smallest);
            Console.WriteLine("The position of the smallest integer is: {0} ", position + 1); //makes it more readable
      
        }
    }
}

