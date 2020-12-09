using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sengstrom1730ex3b1
{
    public class Ex3bCalculations
    {
        public static decimal GetDiscountPercent(decimal subtotal)
        {
            decimal discountPercent = 0m;
            if (subtotal >= 500m)
                discountPercent = 0.2m;
            else
                discountPercent = 0.1m;

            return discountPercent;
        }

        public static void GetDiscountPercent(decimal subtotal, out decimal  discountPercent)
        {          
            if (subtotal >= 500m)
                discountPercent = 0.2m;
            else
                discountPercent = 0.1m;           
        }

        public static decimal CalculateFutureValue(decimal monthlyinvestment, decimal monthlyInterestRate, int months)
        {
            decimal futureValue = 0.0m;       
               
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + monthlyinvestment) * (1 + monthlyInterestRate);
            }
            
            return futureValue;
        }
        public static void CalculateFutureValue(decimal monthlyinvestment, decimal monthlyInterestRate, int months, ref decimal futureValue)
        {            

            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + monthlyinvestment) * (1 + monthlyInterestRate);
            }
        }
        public static double FahrenheitToCelsius(double fahrenheit)
        {
            double celsius = (fahrenheit - 32) * 5 / 9;
            return celsius;
        }

        public static void CelsiusToFahrenheit(double celsius, out double fahrenheit )
        {
          fahrenheit = ((celsius * 1.8) + 32);
            
        }

        public static decimal GrossPay(decimal hours, decimal rate)
        {
            decimal pay = 0m;
            if (hours <= 40)
            {
                pay = rate * hours;
            }
            else
            {
                pay = ((rate * 40) + ((hours - 40) * (1.5m * rate)));
            }
            return pay;
        }
        public static decimal TotalHours(string strNumbers)
        {
            decimal total = 0;
            int startIndex = 0;

            while (startIndex < strNumbers.LastIndexOf(' '))
            {
                int endIndex = strNumbers.IndexOf(' ', startIndex);
                string strNumber = strNumbers.Substring(startIndex, endIndex - startIndex);
                decimal number = decimal.Parse(strNumber);
                total += number;
                startIndex = endIndex + 1;

            }

            return total;
        }
        public static decimal GrossPay(string strNumbers, decimal rate)
        {
            decimal grossPay = 0m;
            decimal totalHours = TotalHours(strNumbers);
            int startIndex = 0;

            while (startIndex < strNumbers.LastIndexOf(' '))
            {
                int endIndex = strNumbers.IndexOf(' ', startIndex);
                string strNumber = strNumbers.Substring(startIndex, endIndex - startIndex);
                decimal number = decimal.Parse(strNumber);
                startIndex = endIndex + 1;               
            }
            grossPay = totalHours * rate;

            return GrossPay(totalHours, rate);
        }
    }
}
