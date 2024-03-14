using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int sizeArray = 30;
            int[] numbers = new int[sizeArray];
            int countRepetitionNumber = 0; 
            int maxNumberReapit = 0;
            int minValue = 0;
            int maxValue = 10;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(minValue,maxValue);
                Console.Write(numbers[i] + " ");
            }

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    countRepetitionNumber++;

                    maxNumberReapit = numbers[i];
                }

            }

            Console.WriteLine($"\nколичество повторений: {countRepetitionNumber} числа: {maxNumberReapit}");
        } 
    }
}
