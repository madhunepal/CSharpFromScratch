using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileLoopDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            int iHaveGoats = 0;
            while (iHaveGoats < 10)
            {
                Console.WriteLine("ihavegoates = {ihavegoates}");
                iHaveGoats++;
            }
        }
    }
}
