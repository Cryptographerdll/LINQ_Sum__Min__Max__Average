using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace LINQ_Sum__Min__Max__Average
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = new int[] { 1, 45, 2, 3, 6, 12, 84 };

            var count_Operation = Numbers.Sum();    // 153
            // Numbers.Max();
            // Numbers.Min();
            // Numbers.Average();

        }
    }
}
