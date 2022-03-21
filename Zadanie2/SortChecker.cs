using System;
using System.Collections.Generic;
using System.Linq;

namespace Task2
{
    public static class SortChecker
    {
        public static bool IsSorted(List<string> prices)
        {
            for (var i = 0; i < prices.Count-1; i++)
            {
                if (Convert.ToInt32(prices.ElementAt(i))<Convert.ToInt32(prices.ElementAt(i+1)))
                {
                    return false;
                }
            }
            return true;
        }
    }
}