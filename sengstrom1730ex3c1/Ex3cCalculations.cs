using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sengstrom1730ex3c1
{
    public class Ex3cCalculations
    {
        private static IEnumerable<double> count;

        public static string Calc0(int index)
        {
            string[] days;
            days = new string[7] { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            days[0] = "Sunday";
            days[1] = "Monday";
            days[2] = "Tuesday";
            days[3] = "Wednesday";
            days[4] = "Thursday";
            days[5] = "Friday";
            days[6] = "Saturday";
            int index1 = Array.IndexOf(days, index);

            if (index1 >= 1 && index1 <= 7)
            {
                return days[].ToString();
            }
            else
                return "Invalid index";


        }

        public static string Calc1(string search)
        {
            search = search.Trim();
            search = search.ToUpper();
            string[] days = { "SUNDAY", "MONDAY", "TUESDAY", "WEDNESDAY", "THURSDAY", "FRIDAY", "SATURDAY" };
            string[] hours = { "Closed", "10am - 6pm", "10am - 6pm", "10am - 6pm", "10am - 9pm", "10am - 6pm", "8am - 4pm" };
            int index = Array.IndexOf(days, search);

            if (index >= 1 && index <= 7)
            {
                return search.ToString();
            }
            else
                return "Invalid input";
        }

        public static int[] Calc2(int[] numbers)
        {
            int sum = 0;
            foreach (int total in numbers)
            {
                sum += total;
            }
            return numbers;
        }
        public static double[] Calc3(double[] numbers, int count)
        {
            double sum = 0;
            for (int i = 0; i < count; i++)
                sum += count;

            return numbers;
        }

        public static double[] Calc5(double[] numbers)
        {
            double sum = 0;
            foreach (double count in count)
                sum += count;
            decimal average = sum / count;

            return new double[10];
        }

        public static double[] Calc6(double[] numbers)
        {

            int length = numbers.GetLength(0);
            List<double> aboveAvgList = new List<double>();
            if (length > 0)
            {
                double avg = Calc5(numbers);
                foreach (int total in aboveAvgList)
                {
                    if (avg > average)
                        aboveAverage++;
                }
                return new double[10];
            }

        }
    }
}