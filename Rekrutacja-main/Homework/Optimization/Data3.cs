using System;

namespace Optimization
{
    internal class Data
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }
	public int R { get; set; }

        public Data()
        {
            var r = new Random();
            A = r.Next(100);
            B = r.Next(100);
            C = r.Next(100);
	    
	    // store preprocessed intermediate result
            R = (int)Math.Pow(A, 2) * (int)Math.Pow(B, 2) * (int)Math.Pow(C, 2);
        }

        public int Calculate(int x)
        {
            // use preprocessed R intermediate result
            return  R * x;
        }

    }
}