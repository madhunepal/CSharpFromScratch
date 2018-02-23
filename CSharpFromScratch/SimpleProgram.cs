using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFromScratch
{
    class SimpleProgram
    {
        static void main(string[] arg)
        {
            int myAge = 32;
            string lastName = "Nepal";
            string firstName = "madhu";
            double myPayRate = 56.00;

            Console.WriteLine($"My Name is" + firstName + "I am" + myAge + "years old" + "and I earn hourly" + myPayRate);
        }
       
    }
}
