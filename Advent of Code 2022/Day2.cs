using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_of_Code_2022
{
    public class Day2
    {
        public static void Run (string? fileName)
        {
            if (fileName == null) return;

            StreamReader sr = new StreamReader (fileName);
            int sum = 0;

            while (!sr.EndOfStream)
            {
#pragma warning disable CS8602 // Dereferencing of a possible null reference 
                char[] guesses = sr.ReadLine().ToCharArray();
#pragma warning restore CS8602 // Dereferencing of a possible null reference
                if (guesses[2] == 'X') sum++;
                if (guesses[2] == 'Y') sum += 2;
                if (guesses[2] == 'Z') sum += 3;

                if (guesses[0] == 'A')
                {
                    if (guesses[2] == 'X') sum += 3;
                    if (guesses[2] == 'Y') sum += 6;
                }
                if (guesses[0] == 'B')
                {
                    if (guesses[2] == 'Y') sum += 3;
                    if (guesses[2] == 'Z') sum += 6;
                }
                if (guesses[0] == 'C')
                {
                    if (guesses[2] == 'Z') sum += 3;
                    if (guesses[2] == 'X') sum += 6;
                }
            }

            sr.Close ();
            Console.WriteLine(sum);

            StreamReader sr2 = new StreamReader(fileName);
            sum = 0;
            
            while (!sr2.EndOfStream)
            {
#pragma warning disable CS8602 // Dereferencing of a possible null reference 
                char[] guesses = sr2.ReadLine().ToCharArray();
#pragma warning restore CS8602 // Dereferencing of a possible null reference
                if (guesses[2] == 'X')
                {
                    if (guesses[0] == 'A') sum += 3;
                    if (guesses[0] == 'B') sum += 1;
                    if (guesses[0] == 'C') sum += 2;
                }
                if (guesses[2] == 'Y')
                {
                    if (guesses[0] == 'A') sum += 4;
                    if (guesses[0] == 'B') sum += 5;
                    if (guesses[0] == 'C') sum += 6;
                }
                if (guesses[2] == 'Z')
                {
                    if (guesses[0] == 'A') sum += 8;
                    if (guesses[0] == 'B') sum += 9;
                    if (guesses[0] == 'C') sum += 7;
                }
                
            }

            sr2.Close();
            Console.WriteLine(sum);
        }
    }
}
