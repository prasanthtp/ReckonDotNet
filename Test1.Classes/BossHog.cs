using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1.Classes
{
    public class BossHog
    {
        /*
        * A function which takes a number and converts it into a string unless it meets the following criteria 
        * If the number is divisible by both 5 & 3 the function returns the word "BossHog"
        * If the number is divisible by 3 the function returns the word "Boss"
        * If the number is divisible by 5 the function returns the word "Hog"
        */

        public static string PrintNumber(int input)
        {
            var sb = new StringBuilder();

            if (input % 3 == 0)
                sb.Append("Boss");
            if (input % 5 == 0)
                sb.Append("Hog");

            if (sb.Length == 0)
                return input.ToString();

            return sb.ToString();
        }
    }
}
