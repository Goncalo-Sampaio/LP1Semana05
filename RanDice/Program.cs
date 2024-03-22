using System;

namespace RanDice
{
    class Program
    {
        static void Main(string[] args)
        {
            //parsing the arguments and instantiating a new Random
            int seed = int.Parse(args[1]);
            int dice = int.Parse(args[0]);
            Random random = new Random(seed);
            int final = 0;

            //Going through each dice and making a sum of each number
            for (int i = 0; i < dice; i++){
                final += random.Next(1, 7);
                Console.WriteLine(final);
            }

            //Showing the result to the user
            Console.WriteLine(final);
        }
    }
}
