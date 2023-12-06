using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        int n = 80000; // number of random numbers to generate
        double[] doubleNumbers = GenerateRandomDoubles(n);
        float[] floatNumbers = CastToFloat(doubleNumbers); // Cast the double array to a float array

        Stopwatch timer = new Stopwatch();

        // Measure the time for adding doubles
        timer.Start();
        AddDoubles(doubleNumbers);
        timer.Stop();
        double doubleAddTime = timer.Elapsed.TotalMilliseconds;

        // Measure the time for adding floats
        timer.Restart();
        AddFloats(floatNumbers);
        timer.Stop();
        double floatAddTime = timer.Elapsed.TotalMilliseconds;

        Console.WriteLine("Addition of Doubles took " + doubleAddTime + " ms");
        Console.WriteLine("Addition of Floats took " + floatAddTime + " ms");

        if (doubleAddTime < floatAddTime)
        {
            Console.WriteLine("Adding doubles is faster.");
        }
        else if (floatAddTime < doubleAddTime)
        {
            Console.WriteLine("Adding floats is faster.");
        }
        else
        {
            Console.WriteLine("Adding doubles and floats take the same amount of time.");
        }
    }

    static double[] GenerateRandomDoubles(int count)
    {
        Random rand = new Random();
        double[] num = new double[count];
        for (int i = 0; i < count; ++i)
        {
            num[i] = 100.0 * rand.NextDouble();
        }
        return num;
    }

    static float[] CastToFloat(double[] doubles)
    {
        float[] floats = new float[doubles.Length];
        for (int i = 0; i < doubles.Length; ++i)
        {
            floats[i] = (float)doubles[i];
        }
        return floats;
    }

    static void AddDoubles(double[] nums)
    {
        for (int i = 0; i < nums.Length; ++i)
        {
            nums[i] = nums[i] + nums[i];
        }
    }

    static void AddFloats(float[] nums)
    {
        for (int i = 0; i < nums.Length; ++i)
        {
            nums[i] = nums[i] + nums[i];
        }
    }
}
