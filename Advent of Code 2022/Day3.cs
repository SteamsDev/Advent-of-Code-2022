using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Advent_of_Code_2022
{
    public class Day3
    {
        public static void Run (string? fileName)
        {
            if (fileName == null) return;

            StreamReader sr = new StreamReader (fileName);
            bool notDup = false;
            int result = 0;
            while (!sr.EndOfStream)
            {
                string? line = sr.ReadLine ();
                if (line == null) continue;
                char[] firstHalf = line.Substring(0, line.Length / 2).ToCharArray();
                char[] secondHalf = line.Substring(line.Length / 2).ToCharArray();
                for (int i = 0; i < firstHalf.Length; i++)
                {
                    for (int j = 0; j < secondHalf.Length; j++)
                    {
                        if (firstHalf[i] == secondHalf[j])
                        {
                            if (!notDup) notDup = true;
                            if (firstHalf[i].ToString().ToLower() == firstHalf[i].ToString())
                            {
                                result += firstHalf[i] - 96;
                            }
                            else
                            {
                                result += firstHalf[i] - 38;
                            }
                            break;
                        }
                    }
                    if (notDup) break;
                }
                notDup = false;
            }
            sr.Close();
            Console.WriteLine(result);

            sr = new StreamReader (fileName);
            result = 0;
            notDup = false;
            while (!sr.EndOfStream)
            {
                string[] lines = { sr.ReadLine(), sr.ReadLine(), sr.ReadLine() };
                if (lines[0] == null || lines[1] == null || lines[2] == null) continue;
                for (int i = 0; i < lines[0].Length; i++)
                {
                    for (int j = 0; j < lines[1].Length; j++)
                    {
                        for (int k = 0; k < lines[2].Length; k++)
                        {
                            if (lines[0][i] == lines[1][j] && lines[1][j] == lines[2][k] && lines[0][i] == lines[2][k])
                            {
                                if (!notDup) notDup = true;
                                if (lines[0][i].ToString().ToLower() == lines[0][i].ToString())
                                {
                                    result += lines[0][i] - 96;
                                }
                                else
                                {
                                    result += lines[0][i] - 38;
                                }
                                break;
                            }
                        }
                        if (notDup) break;
                    }
                    if (notDup) break;
                }
                notDup = false;
            }
            sr.Close();
            Console.WriteLine(result);
        }
    }
}
