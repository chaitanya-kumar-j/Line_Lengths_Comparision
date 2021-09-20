using System;

namespace LineLengths
{
    class Program
    {
        static void Main(string[] args)
        {
            // Two line lengths are...
            double line1Length = new Lines().Length(0, 6, 0, 8);
            double line2Length = new Lines().Length(0, 8, 0, 8);

            // Check equality of lengths of given two lines.
            new Lines().IsEqual(line1Length, line2Length);
        }
    }
}
