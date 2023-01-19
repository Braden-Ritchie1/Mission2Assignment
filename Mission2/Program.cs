using System;

namespace Mission2
{
    class Program
    {
        static void Main(string[] args)
        {
            //create the random number generator
            Random r = new Random();

            //declare the numRolls variable
            double numRolls;

            //set up the intro and input for numRolls
            Console.WriteLine("Welcome to the dice throwing game!");
            Console.WriteLine("How many dice rolls would you like to do?");
            numRolls = double.Parse(Console.ReadLine());

            //set up the array with 6 spots
            int[] rollResults = new int[13];

            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each ' * ' represents 1% of the total number of rolls.");
            Console.WriteLine("Total Number of Rolls: " + numRolls);
            //simulate the roll of both die
            for (int counter = 0; counter < numRolls; counter++)
            {
                int dice1 = r.Next(1,7);

                int dice2 = r.Next(1, 7);

                int totalDice = dice1 + dice2;

                rollResults[totalDice]++;
            }

            //print out the results for each rolled number
            for (int counter = 2; counter < 13; counter++)
            {
                double per = ((rollResults[counter] / numRolls) * 100);

                Console.Write(counter + ": ");

                //print out the number of astricks needed for each number on the die
                for (int i = 0; i < per; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }
            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
            Console.ReadLine();

        }
    }
}
