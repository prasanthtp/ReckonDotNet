using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2.Classes
{
    public class SubString
    {
        //This function matches the subtext against the textToSearch,
        //output string contains the positions of the beginning of each match for the subtext within the textToSearch.
        // If no matches have been found, out put will be “<No Output>”  

        public static string Find(string textToSearch, string subtext)
        {

            if (string.IsNullOrEmpty(textToSearch) && string.IsNullOrEmpty(subtext))
                return "1";

            if (string.IsNullOrEmpty(textToSearch) || string.IsNullOrEmpty(subtext))
                return "<No Output>";


            var outPut = new StringBuilder();
            bool matchFound;

            for (int i = 0; i < textToSearch.Length - subtext.Length + 1; ++i)
            {
                matchFound = true;
                for (int j = 0; j < subtext.Length; ++j)
                {
                    if (char.ToLower(textToSearch[i + j]) != char.ToLower(subtext[j]))
                    {
                        matchFound = false;
                        break;
                    }
                }
                if (matchFound) outPut.Append(string.Format("{0}, ", (i + 1).ToString()));
            }

            if (outPut.Length == 0)
                return "<No Output>";

            return outPut.ToString().Trim().TrimEnd(',');
        }
    }
}
