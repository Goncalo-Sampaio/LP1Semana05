using System;
using System.Diagnostics;
using System.Threading;

namespace Chronos
{
    /// <summary>
    /// Program that creates stopwatches, starts them at different times and
    /// shows the user the elapsed time
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiating new stopwatches
            Stopwatch crono1 = new Stopwatch();
            Stopwatch crono2 = new Stopwatch();

            //Starting stopwatches and stopping the thread for some time
            crono1.Start();

            Thread.Sleep(600);

            crono2.Start();

            Thread.Sleep(200);

            //Stopping the stopwatches
            crono1.Stop();
            crono2.Stop();

            //Getting the time elapsed, formatting it and showing it to the user
            TimeSpan ts = crono1.Elapsed;
            TimeSpan ts2 = crono2.Elapsed;
            string elapsedTime = String.Format("{0:0}.{1:000}", ts.Seconds,
                ts.Milliseconds);
            string elapsedTime2 = String.Format("{0:0}.{1:000}", ts2.Seconds,
                ts2.Milliseconds);
            Console.WriteLine(elapsedTime);
            Console.WriteLine(elapsedTime2);
        }
    }
}
