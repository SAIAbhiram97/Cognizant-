using System;

namespace FinancialForecasting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Current Value: ");
            string? currentValueInput = Console.ReadLine();
            double currentValue = double.TryParse(currentValueInput, out double currentValueParsed)
                ? currentValueParsed
                : 0.0;

            Console.Write("Enter Annual Growth Rate (%): ");
            string? growthRateInput = Console.ReadLine();
            double growthRate = double.TryParse(growthRateInput, out double growthRateParsed)
                ? growthRateParsed / 100
                : 0.0;

            Console.Write("Enter Number of Years: ");
            string? yearsInput = Console.ReadLine();
            int years = int.TryParse(yearsInput, out int yearsParsed)
                ? yearsParsed
                : 0;

            double futureValue = Forecast.PredictFutureValue(currentValue, growthRate, years);

            Console.WriteLine("\nFuture Value = " + futureValue);

            Console.ReadLine();
        }
    }
}