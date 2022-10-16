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
	    
	    // store calculated result
            R = (int)Math.Pow(A, 2) * (int)Math.Pow(B, 2) * (int)Math.Pow(C, 2) * r.Next(1000);
        }

        public int Calculate()
        {
            // use calculated R result
            return  R;
        }

    }
}