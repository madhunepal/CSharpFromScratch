using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oddEven {
    class Calculation
    {
        static void Main()
        {

            // Print even numbers between 0 and 100.
            for (int i = 0; i <= 100; i++)
            {
                if ((i % 2) != 0)
                    continue; // iterate
                Console.WriteLine(i);
            }
        }
    }
}
