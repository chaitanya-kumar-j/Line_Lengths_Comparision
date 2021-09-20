using System;
using System.Collections.Generic;
using System.Text;

namespace LineLengths
{
    class Lines
    {
        public double Length(double x1, double x2, double y1, double y2)
        {
            double length = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return length;
        }
        public void IsEqual(double line1Length, double line2Length)
        {
            if (line1Length.Equals(line2Length))
                Console.WriteLine("Both lines are of equal length.");
            else
                Console.WriteLine("Both lines are of different length.");
        }
    }
}
