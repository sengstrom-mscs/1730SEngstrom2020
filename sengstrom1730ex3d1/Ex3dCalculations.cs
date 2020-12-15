using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sengstrom1730ex3d1
{
    public class Ex3dCalculations
    {
        public static string ArrayToString(int[] values)
        {
            string result = "";
            StringBuilder sbResult = new StringBuilder(200);
            foreach (int value in values)
            {
                result = sbResult.ToString();
                result += value + ", ";
            }

            sbResult.Append(", ");

            return result.Remove(result.LastIndexOf(", "));
        }

        public static int ValueCount(int[] values, int searchValue)
        {
            int count = 0;

            foreach (int number in values)
            {
                if (number == searchValue)
                    count++;
            }

            return count;
        }



        public static int RangeCount(int[] values, int searchMin, int searchMax)
        {

            int count = 0;

            foreach (int number in values)
            {
                if (number >= searchMin && number <= searchMax)
                    count++;
            }

            return count;
        }
    }
}

