using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test2.Classes;

namespace Test2
{
    class Program
    {
        /* 
          Test 2:
                Preface:
                Do not use any extended functionality of the framework to solve this problem. (For example,don't use the string finding methods of IndexOf, 
                substring, regular expression classes, etc).

                Problem:
                We need a way of finding all the occurrences of a particular set of characters in a string.
                    > We need a class that has a public method named “Find” that returns a string
                    > This method accepts two strings as input. One called 'textToSearch' and one called 'subtext'
                    > The solution should match the subtext against the textToSearch, outputting the positions of the beginning of each match for the subtext within the textToSearch.
                    > Multiple matches are possible
                    > Matching is case insensitive
                    > If no matches have been found, “<No Output>” is generated
          */

        static void Main(string[] args)
        {
            Console.WriteLine("Please type the main string and press Enter : ");
            string mainString = Console.ReadLine();
            Console.WriteLine("Please type the subString and press Enter : ");
            string subString = Console.ReadLine();
            var outPut = SubString.Find(mainString, subString);

            Console.Write(outPut);
            Console.ReadLine();
        }
    }
}
