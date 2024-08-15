using System;
using System.Diagnostics;
using System.Threading;
class Program
{
    static void Main(string[] args)
    {
        static long Fibonacci(int i)
        {
            if (i == 0) return 0;
            if (i == 1) return 1;
            if (i == 2) return 1;
            return Fibonacci(i - 1) + Fibonacci(i - 2);
            // return 0; dummy

        }
        Stopwatch stopWatch = new Stopwatch();
        stopWatch.Start();
        Thread.Sleep(10000);
        stopWatch.Stop();
        // Get the elapsed time as a TimeSpan value.
        TimeSpan ts = stopWatch.Elapsed;

        // Format and display the TimeSpan value.
        string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
        Console.WriteLine("RunTime " + elapsedTime);
    }
}
