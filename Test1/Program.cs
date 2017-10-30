using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test1.Classes;

namespace ReckonCodingTest
{
    class Program
    {
        /*
        Test 1:
        Write some code that prints the numbers from 1 to 100. But for multiples of three print “Boss”
        instead of the number and for the multiples of five print “Hog”. For numbers which are multiples
        of both three and five print “BossHog”."
        */


        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(BossHog.PrintNumber(i));
            }
            Console.ReadLine();
        }
    }
}
