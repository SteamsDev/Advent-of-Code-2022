using System;
using System.IO;

public class Day1
{

    public static void Run(string? fileName)
	{
        if (fileName == null) return;

        StreamReader inputFile = new StreamReader(fileName);
        int sumOfValues = 0;
        int maxValue = 0;
        int[] topThreeValues = { 0, 0, 0 };

        while (!inputFile.EndOfStream)
        {
#pragma warning disable CS8604 // Possible null reference argument for parameter 's' in 'int int.Parse(string s)'.
            try
            {
                int input = int.Parse(inputFile.ReadLine());
                sumOfValues += input;
            }
            catch (FormatException e)
            {
                Console.WriteLine("Newline reached");
                if (maxValue < sumOfValues)
                {
                    topThreeValues[2] = topThreeValues[1];
                    topThreeValues[1] = topThreeValues[0];
                    topThreeValues[0] = sumOfValues;
                    maxValue = sumOfValues;
                }
                else if (topThreeValues[1] < sumOfValues)
                {
                    topThreeValues[2] = topThreeValues[1];
                    topThreeValues[1] = sumOfValues;
                }
                else if (topThreeValues[2] < sumOfValues)
                {
                    topThreeValues[2] = sumOfValues;
                }
                sumOfValues = 0;
            }
#pragma warning restore CS8604 // Possible null reference argument for parameter 's' in 'int int.Parse(string s)'.
        }
        int result = topThreeValues.Sum();

        Console.WriteLine(topThreeValues[0].ToString() + "\n" + topThreeValues[1].ToString() + "\n" + topThreeValues[2].ToString() + "\n" + result);
	}
}
