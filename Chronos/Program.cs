using System;
using System.Diagnostics;
using System.Threading;

namespace Chronos
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch crono1 = new Stopwatch();
            Stopwatch crono2 = new Stopwatch();

            crono1.Start();

            Thread.Sleep(600);

            crono2.Start();

            Thread.Sleep(200);

            crono1.Stop();
            crono2.Stop();

            TimeSpan ts = crono1.Elapsed;
            TimeSpan ts2 = crono2.Elapsed;

            // Format and display the TimeSpan value.
            string elapsedTime = String.Format("{0:0}.{1:000}", ts.Seconds,
                ts.Milliseconds);
            string elapsedTime2 = String.Format("{0:0}.{1:000}", ts2.Seconds,
                ts2.Milliseconds);
            Console.WriteLine(elapsedTime);
            Console.WriteLine(elapsedTime2);
        }
    }
}
