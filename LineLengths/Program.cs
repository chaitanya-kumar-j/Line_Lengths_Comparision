using System;

namespace LineLengths
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calculate length of line between two given points.
            double length = new Lines().Length(0,8,6,0);
            Console.WriteLine($"Length of the line is: {length}");
        }
    }
}
