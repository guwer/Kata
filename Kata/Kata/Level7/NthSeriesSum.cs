using System.Globalization;

namespace Kata.Level7
{
    public class NthSeriesSum
    {
        public static string SeriesSum(int n)
        {
            float sum = 0.00f;
            float denominator = 1;
            for (int i = 1; i <= n; i++)
            {
                sum = sum + (1 / denominator);
                denominator = denominator + 3;
            }

            var result = sum.ToString("0.00", CultureInfo.InvariantCulture);
            return result;
        }
    }
}