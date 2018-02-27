using System;

namespace CSharpFromScratch
{
    class Method
    {
        // create the score variable 
        public static int myScore;
        // main function of the program
        static void Main (String [] args)
        {
            myScore = 1000;
            ChangeScore();
        }
        public static void ChangeScore()
        {
            myScore = myScore + 10;
        }
         public static void DisplayScore()
        {
            Console.WriteLine("player score: {myScore}");
        }

    }

}
