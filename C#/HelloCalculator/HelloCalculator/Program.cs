using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = AddNumbers(23424, 242342);
            Console.WriteLine(result);
            Console.ReadKey();

        }

        private static int AddNumbers(int numberOne, int numberTwo)
        {
            int calculationResult;

            calculationResult = numberOne + numberOne;
            return calculationResult;
        }

    }
}
