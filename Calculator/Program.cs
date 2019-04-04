using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new CalculationEngine();

            Console.WriteLine("Give me an addition problem, please?");
            var input = Console.ReadLine();

            try
            {
                var result = calculator.DoMath(input);
                Console.Write($"The result of your problem is {result}");
            }
            catch (InvalidInputException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
