using System;

namespace RanDice
{
    class Program
    {
        static void Main(string[] args)
        {
            int seed = int.Parse(args[1]);
            int dice = int.Parse(args[0]);
            Random random = new Random(seed);
            int final = 0;

            for (int i = 0; i < dice; i++){
                final += random.Next(1, 7);
                Console.WriteLine(final);
            }

            Console.WriteLine(final);
        }
    }
}
