using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace TP03
{
    /// <summary>
    /// Some general utils
    /// </summary>    
    public static class Utils
    {
        /// <summary>
        /// Calculate the Greater Common Divisor between 2 integers
        /// </summary>
        /// <param name="a">first integer (must be >0)</param>
        /// <param name="b">second integer (must be >0)</param>
        /// <returns>The GCD of a and b</returns>
        /// <pre>a>0</pre>
        /// <pre>b>0</pre>
        /// <post>Gcd>0</post>
        public static int Gcd(int a, int b)
        {
            Debug.Assert(a > 0);
            Debug.Assert(b > 0);
            if (a < b)
            {
                int temp = a;
                a = b;
                b = temp;
            }
            int r = a % b;
            while (r != 0)
            {
                a = b;
                b = r;
                r = a % b;
            }
            Debug.Assert(b > 0);
            return b;
        }
    }
}
