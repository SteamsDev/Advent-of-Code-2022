using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_of_Code_2022
{
    public class Day4
    {
        public static void Run (string? fileName)
        {
            if (fileName == null) return;

            StreamReader sr = new StreamReader (fileName);
            int result = 0;

            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine ();
                string lower = line.Split(",")[0];
                string upper = line.Split(",")[1];
                int lowerOne = int.Parse(lower.Split("-")[0]);
                int lowerTwo = int.Parse(lower.Split("-")[1]);
                int upperOne = int.Parse(upper.Split("-")[0]);
                int upperTwo = int.Parse(upper.Split("-")[1]);

                if (lowerOne >= upperOne && lowerTwo <= upperTwo || upperOne >= lowerOne && upperTwo <= lowerTwo)
                {
                    result++;
                }
            }

            sr.Close();
            Console.WriteLine(result);

            sr = new StreamReader (fileName);
            result = 0;

            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine ();
                string lower = line.Split(",")[0];
                string upper = line.Split(",")[1];
                int lowerOne = int.Parse(lower.Split("-")[0]);
                int lowerTwo = int.Parse(lower.Split("-")[1]);
                int upperOne = int.Parse(upper.Split("-")[0]);
                int upperTwo = int.Parse(upper.Split("-")[1]);

                if (lowerTwo >= upperOne && upperTwo >= lowerOne)
                {
                    result++;
                }
            }

            sr.Close();
            Console.WriteLine(result);
        }
    }
}
