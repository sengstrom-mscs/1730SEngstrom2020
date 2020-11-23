using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace sengstrom1730ex2H
{
    public class Ex2hCalculations
    {
        public static string DateCalc06 (string strYear, string strMonth, string strDay)
        {
            string result = "Invalid input";
            DateTime date;
            try 
            { 
            int year = Int32.Parse(strYear);
            int month = Int32.Parse(strMonth);
            int day = Int32.Parse(strDay);
            date = new DateTime(year, month, day);
            result = date.ToShortDateString();
            }
            catch { }
                        
            return result;

        }
        public static string DateCalc07(string strDate)
        {
            string result = "Invalid input";
            DateTime date;
            try
            {
                date = DateTime.Parse(strDate);
                result = date.ToShortDateString();
            }
            catch { }

            return result;

        }
        public static string DateCalc08(string strDate)
        {
            string result = "Invalid input";
            DateTime date;
            DateTime.TryParse(strDate, out date);
            result = date.ToShortDateString();
            return result;
        }

        public static string DateCalc09(string strDateA, string strDateB)
        {
            string result = "Invalid input";
            DateTime dateA;
            DateTime dateB;

            try
            {
                dateA = DateTime.Parse(strDateA);
                dateB = DateTime.Parse(strDateB);
                TimeSpan days= dateA.Subtract(dateB);
                result = days.TotalDays.ToString() + " days";
            }
            catch { }
            return result;

        }
        public static string DateCalc10(string strDateA, string strDateB)
        {
            string result = "Invalid input";
            DateTime dateA;
            DateTime dateB;
                       
            dateA = DateTime.Parse(strDateA);
            dateB = DateTime.Parse(strDateB);
            TimeSpan days = dateA.Subtract(dateB);

            if (dateA > dateB)
            {
                result = days.TotalDays.ToString() + " days past due";
            }

            else if (dateA <= dateB)
            {
                return "On time";
            }
            else
                return "Invalid input";
            return result;
        }
        public static string StringCalc01(string s)
        {

            s = s.Trim();
            if (s.Length > 1)
            {
                s = s.Remove(0, 1);
                s = s.Insert(0, "cr");
            }
            else
                return "Invalid Input";
            return s;
        }

        public static string StringCalc02(string s)
        {
            s = s.Trim();
            if (s.Length > 1)
            {
                s = s.Remove(1, 1);
                s = s.Insert(1, "rit");
            }
            else
                return "Invalid Input";
            return s;
        }

        public static string StringCalc03(string s)

        { 
            if (s.Length > 1)
            {
                s = s.Trim();
                s = s.Substring(2, 4).ToUpper();
            }
            else
                return "Invalid Input";
            return s;
        }

        public static string StringCalc04(string s)
        {
            if (s.Length > 1)
            {
                s = s.PadLeft(10, '*').Trim();
            }
            else
                return "Invalid Input";
            return s;
        }

        public static string StringCalc05(string s)
        {

            if (s.Length > 1)
            {                
                s = s.Replace("(", "");
                s = s.Replace(") ", "");
                s = s.Replace("-", "");
                s = s.Trim();
            }
            else
                return "Invalid Input";
            return s;
        }

        public static string StringCalc06(string s)
        {

            if (s.Length > 1)
            {
                s = s.Replace("(", "");
                s = s.Replace(") ", "");
                s = s.Replace("-", "");
                s = s.Trim();
            }
            if (s.Length == 7)
             s = s.Insert(3, "."); 
            if (s.Length == 10)
            s = s.Insert(3, ".");
            s = s.Insert(7, ".");
            return s;
        }

        public static string StringCalc07(string s)
        {
            if (s.Length > 1)
            {
                s = s.ToLower();
                if (s.Contains("pioneer"))
                    return "Found";
                else
                    return "Not found";
            }
            else
                return "Invalid Input";            

        }

        public static string StringCalc08(string s)
        {
            if (s.Length > 1)
            {                             
                int sIndex = s.IndexOf(", ") +1;
                return s.Substring(sIndex);
            }
            else
                return "Invalid Input";
        }

        public static string StringCalc09(string s)
        {
            {
                if (s.Length > 1)
                {                    
                    int sIndex = s.LastIndexOf(" ");
                    return s.Substring(sIndex);
                }
                else
                    return "Invalid Input";
            }
        }
        public static string StringCalc10(string s1, string s2, string s3)
        {
            StringBuilder sb = new StringBuilder(100);
            sb.Append(s1);
            sb.Append(s2);
            sb.Append(s3);
            return sb.ToString();
        }
    }
    }
