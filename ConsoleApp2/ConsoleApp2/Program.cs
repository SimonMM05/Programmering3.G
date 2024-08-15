using System;
using System.Diagnostics;
class Program
{
    static void Main(string[] args)
    {
        static long Fibonacci(int i)
        {
            if (i == 0) return 0;
            if (i == 1) return 1;
            return Fibonacci(i - 1) + Fibonacci(i - 2);
        }

        // Set the number of Fibonacci terms to calculate
        int n = 44; // You can change this value to calculate more or fewer terms

        Stopwatch stopWatch = new Stopwatch();
        stopWatch.Start();

        // Calculate and print the Fibonacci sequence
        for (int i = 0; i <= n; i++)
        {
            Console.WriteLine($"Fibonacci({i}) = {Fibonacci(i)}");
        }

        stopWatch.Stop();

        // Get the elapsed time as a TimeSpan value
        TimeSpan ts = stopWatch.Elapsed;

        // Format and display the TimeSpan value
        string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
        Console.WriteLine("RunTime " + elapsedTime);
    }
}