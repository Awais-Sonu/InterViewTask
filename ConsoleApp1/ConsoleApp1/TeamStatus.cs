using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
//    Create a function that determines whether a number is in Odd Team or Even Team.
//A number is in Odd Team if the sum of all of its
//digits is odd, and a number is in Even Team if the
//sum of all of its digits is even.
//For example, FUNCTION(121) should return "Even Team",
//since 1 + 2 + 1 = 4. FUNCTION(41) should return "Odd Team", since 4 + 1 = 5.
    public static class TeamStatus
    {
        public static string SanatizeString(this string stringToBeFiltered) 
        {
            char[] chars = stringToBeFiltered.ToCharArray();
            StringBuilder sb = new StringBuilder();
            foreach (char c in chars)
            {
                if (c>='0' && c<='9')
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }
        public static string GetTeam(string number) 
        {
            int sum = 0;
            char[] chars = number.ToCharArray();
            foreach (char c in chars)
            {
                sum += (int)c;
            }
            if (sum % 2 == 0)
            {
                return "Even Team";
            }
            else
            {
                return "Odd Team";
            }
        }
    }
}
