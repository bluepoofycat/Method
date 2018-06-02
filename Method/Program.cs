using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Program
    {
       static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                PatternGenerator.GenerateEachRow(i + 1);
            }
        }
    }

    class PatternGenerator
    {
        public static void GenerateEachRow(int columnCount)
        {
            for (int j = 0; j < columnCount; j++)
            {
                GenerateEachColumn(j);
            }
            Console.WriteLine();
        }

        private static void GenerateEachColumn(int j)
        {
            Console.Write(GiveMeANumberAboutJ(j) + " ");
        }

        private static double GiveMeANumberAboutJ(int j)
        {
            return Math.Pow(2, j);
        }
    }
}
