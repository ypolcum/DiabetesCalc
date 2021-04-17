// CIS 199-XX
// Spring 2019
// Exam 1, Part 3 - Console Solution
// Andrew L. Wright
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console; // Don't forget that you need to add this
                             // if you want to use shortcut names, like WriteLine()

namespace CIS199Exam1S19_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            double a1c; // a1c input

            // Gather input
            Write("Enter your A1C test result %: ");
            a1c = double.Parse(ReadLine());

            // Decision logic
            if (a1c >= 6.45) // Magic #s allowed on exam
                WriteLine("Warning! Likely Type 2 Diabetes");
            else if (a1c >= 5.65)
                WriteLine("Warning! Likely Prediabetes");
            else // Must be OK
                WriteLine("Good job! No diabetes detected");
        }
    }
}
