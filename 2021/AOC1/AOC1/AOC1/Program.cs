using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
namespace AOC1
{
	class Program
	{
       
        static void Main(string[] args)
		{
            String line;
            int currentNumber = 0;
            int lastNumber = 0;
            int larger = 0;
            int smaller = 0;
            int theSame = 0;
            String[] lines = File.ReadLines("D:/HKU/AdventOfCode/AOC1/AOC1/input.txt").ToArray<string>() ;
            line = "";
            int[] numberArray =  Array.ConvertAll(lines, int.Parse);
			for (int i = 0; i < numberArray.Length; i++)
			{
                currentNumber += numberArray[i];
                if (currentNumber > lastNumber)
                {
                    line = currentNumber + " (INCREASING)";
                    larger++;
                }
                else if (currentNumber < lastNumber)
                {
                    line = currentNumber + " (DECREASING)";
                    smaller++;
                }
                else
                {
                    line = currentNumber + " (N/A - no previous measurement)";
                    theSame++;
                }
                Console.WriteLine(line);
                lastNumber = currentNumber;
                if (i >= 2)
                {
                    currentNumber -= numberArray[i - 2];
                }
            }
            Console.WriteLine("Times increased: " + larger);
            Console.WriteLine("Times decreased: " + smaller);
            Console.WriteLine("Times the same: " + theSame);
            Console.ReadLine();
        }
	}
}
