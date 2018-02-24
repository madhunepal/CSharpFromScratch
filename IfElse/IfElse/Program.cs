using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            int madhu = 20;
            int shanti = 16;
            
            int sita = 30;
            if (sita > 18)
            {
                Console.WriteLine("she can vote");
            }
            if (shanti>=21 && madhu >= 21)
            {
                Console.WriteLine("shanti and madhu can drink");

            }
            else if (shanti >=21 || madhu >= 21)
            {
                Console.WriteLine("at least one of them can drink");
            }
            else
            {
                Console.WriteLine("checke age again");
            }
        }
    }
}
