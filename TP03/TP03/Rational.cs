using System;
using System.Collections.Generic;
using System.Text;

namespace TP03
{
    /// <summary>
    /// Exception throws when syntax is not good
    /// </summary>
    class BadSyntaxException : Exception
    { }

    /// <summary>
    /// A rational number
    /// </summary>    
    public class Rational
    {
        private int numerator;
        private int denominator;

        /// <summary>
        /// Initialize the rational
        /// </summary>
        /// <param name="n">value of numerator (default 0)</param>
        /// <param name="d">value of denominator (default 1)</param>
        /// <exception cref="ArithmeticException">If d is egal to 0</exception>
        public Rational(int n=0, int d=1)
        {
            if (d == 0) throw new ArithmeticException();
            numerator = n;
            denominator = d;
            Normalize();
        }

        /// <summary>
        /// Initialize the rational
        /// </summary>
        /// <param name="s">a string representation, type "num/den"</param>
        /// <exception cref="BadSyntaxException">If syntax is bad</exception>
        public Rational(string s)
        {
            string[] parts = s.Split('/');
            if (parts.Length != 2) throw new BadSyntaxException();
            try
            {
                numerator = Convert.ToInt32(parts[0]);
                denominator = Convert.ToInt32(parts[1]);
                Normalize();
            }
            catch
            {
                throw new BadSyntaxException();
            }
            
        }

        public override string ToString()
        {
            return numerator.ToString() + "/" + denominator.ToString();
        }

        /// <summary>
        /// Add another rational
        /// </summary>
        /// <param name="r">other rational</param>
        public void Add(Rational r)
        {
            numerator = numerator * r.denominator + denominator * r.numerator;
            denominator = denominator*r.denominator;
            Normalize();
        }

        /// <summary>
        /// Multiplies by another rational
        /// </summary>
        /// <param name="r">other rational</param>
        public void Multiplies(Rational r)
        {
            numerator *= r.numerator;
            denominator *= r.denominator;
            Normalize();
        }

        private void Normalize()
        {
            if(numerator!=0)
            {
                int gcd = Utils.Gcd(Math.Abs(numerator), Math.Abs(denominator));
                numerator /= gcd;
                denominator /= gcd;
            }
            
        }

        public override bool Equals(object obj)
        {
            return obj is Rational rational &&
                   numerator == rational.numerator &&
                   denominator == rational.denominator;
        }

        /// <summary>
        /// Tells if the rational is less than r
        /// </summary>
        /// <param name="r">other rational</param>
        /// <returns>true si this<r</returns>
        public bool IsLessThan(Rational r)
        {
            return ToDouble() < r.ToDouble();
        }

        /// <summary>
        /// Convert to double value
        /// </summary>
        /// <returns>the double value</returns>
        public double ToDouble()
        {
            double result = numerator / (double)denominator;
            return result;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(numerator, denominator);
        }
    }
}
