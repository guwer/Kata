using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.Level7
{
    public class Square
    {
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
    }
}