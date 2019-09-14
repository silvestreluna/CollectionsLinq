using System;
using System.Collections.Generic;

namespace RandSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            var myNums = new List<int>();
            var mySquaredNums = new List<int>();
            var myEvenSquaredNum = new List<int>();

            var counter = 1;
            while (counter <= 20)
            {
                var randomNumber = rnd.Next(1, 50);

                var tempSquaredNum = (int)Math.Pow(randomNumber, 2);

                myNums.Add(randomNumber);
                mySquaredNums.Add(tempSquaredNum);
                counter++;
            }
            
            foreach(var currentSquaredNum in mySquaredNums)
            {
                Console.WriteLine($"Final squared number is: {currentSquaredNum}");
                if (currentSquaredNum % 2 == 0)
                {
                    myEvenSquaredNum.Add(currentSquaredNum);
                }
            }

            foreach(var currentEvenNum in myEvenSquaredNum)
            {
                Console.WriteLine($"***This are my even numbers: {currentEvenNum}");
            }
        }
    }
}
