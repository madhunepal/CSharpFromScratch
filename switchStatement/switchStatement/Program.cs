using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchStatement
{
    class Program
    {
        enum Movies
        {
            Thuli,
            Kri,
            Baagh,
        }
        static void Main(string[] args)
        {
            Movies bestMovie = Movies.Baagh;
            switch (bestMovie)
            {
                case Movies.Thuli:
                    Console.WriteLine("This is women empoerment movie");
                    break;
                case Movies.Baagh:
                    Console.WriteLine("I will make him an offer....");
                    break;
                case Movies.Kri:
                    Console.WriteLine("This is flop movie");
                    break;
                default:
                    Console.WriteLine("you must make an choice");
                    break;

            }
        }
    }
}
