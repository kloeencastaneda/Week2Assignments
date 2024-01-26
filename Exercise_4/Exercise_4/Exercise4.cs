using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> LC = new Dictionary<char, int>(); //LC stands for letter count
            char letter;

            Console.WriteLine("Enter letters. To stop, press 0: ");

            do
            {
                letter = Convert.ToChar(Console.ReadLine());
                if (letter != '0')
                {
                    LC.TryGetValue(letter, out int count); //gets count value associated with letter
                    LC[letter] = count + 1;
                }
            } while (letter != '0');

            Console.WriteLine("Letter count: ");
            foreach (KeyValuePair<char, int> pair in LC)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");


            }
        }
    }
}
