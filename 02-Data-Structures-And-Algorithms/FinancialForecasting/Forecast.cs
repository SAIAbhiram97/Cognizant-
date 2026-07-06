using System;

namespace FinancialForecasting
{
    public class Forecast
    {
        // Recursive method to calculate future value
        public static double PredictFutureValue(double currentValue, double growthRate, int years)
        {
            // Base case
            if (years == 0)
                return currentValue;

            // Recursive case
            return PredictFutureValue(currentValue, growthRate, years - 1) * (1 + growthRate);
        }
    }
}