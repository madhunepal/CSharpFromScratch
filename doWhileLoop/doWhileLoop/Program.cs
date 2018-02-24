using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int wildTurkey = 0;
            do
            {
                Console.WriteLine("wildturkey = {wildturkey}");
                wildTurkey++;
            }
            while (wildTurkey < 1);
            
        }
    }
}
