using System;
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
        }
    }
}
