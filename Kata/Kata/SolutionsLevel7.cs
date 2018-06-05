using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Kata.Level7
{
    public class SolutionsLevel7
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

        public static string HighAndLow(string numbers)
        {
            var tabInt = numbers.Split(' ').Select(p => Int32.Parse(p)).ToArray();
            Array.Sort(tabInt);
            return $"{tabInt[tabInt.Length - 1]} {tabInt[0]}";
        }

        public static bool IsSquare(int n)
        {
            if (n < 0) return false;
            var i = 0;
            while (i <= n)
            {
                var res = i * i;
                if (res == n) return true;
                i++;
            }
            return false;
        }

        public static string ReverseWords(string str)
        {
            var words = new StringBuilder();
            var word = string.Empty;
            var chars = str.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                var current = chars[i];

                if (!char.IsWhiteSpace(current))
                {
                    word = word + current;

                    if (i < chars.Length - 1)
                    {
                        continue;
                    }
                }
                words.Append(word.Reverse().ToArray());
                word = string.Empty;

                if (string.IsNullOrWhiteSpace(current.ToString()))
                {
                    words.Append(current.ToString());
                }
            }
            return words.ToString();
        }
    }
}