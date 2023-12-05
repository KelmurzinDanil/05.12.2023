using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tum_14
{
    [DeveloperInfo("Данил", "30.11.23")] // Атрибут для вывода инфы
    internal class RationalNumbers
    {
        private int numerator;
        private int denominator;

        public int Numerator { get { return numerator; } }
        public int Denominator { get { return denominator; } }
        public RationalNumbers(int numerator, int denominator)
        {
            if (denominator == 0)
                throw new ArgumentException("Знаменатель не должен равняться нулю");

            this.numerator = numerator;
            this.denominator = denominator;
        }

        public static RationalNumbers operator +(RationalNumbers n1, RationalNumbers n2)
        {
            return new RationalNumbers((n1.Numerator * n2.Denominator) + (n2.Numerator * n1.Denominator), n1.Denominator * n2.Denominator);
        }
        public static RationalNumbers operator -(RationalNumbers n1, RationalNumbers n2)
        {
            return new RationalNumbers((n1.Numerator * n2.Denominator) - (n2.Numerator * n1.Denominator), n1.Denominator * n2.Denominator);
        }
        public static RationalNumbers operator *(RationalNumbers n1, RationalNumbers n2)
        {
            return new RationalNumbers(n1.Numerator * n2.Numerator, n1.Denominator * n2.Denominator);
        }
        public static RationalNumbers operator /(RationalNumbers n1, RationalNumbers n2)
        {
            return new RationalNumbers(n1.Numerator * n2.Denominator, n1.Denominator * n2.Numerator);
        }
        public static RationalNumbers operator ++(RationalNumbers n)
        {
            return new RationalNumbers(n.Numerator + n.Denominator, n.Denominator);
        }
        public static RationalNumbers operator --(RationalNumbers n)
        {
            return new RationalNumbers(n.Numerator - n.Denominator, n.Denominator);
        }
        public static int operator %(RationalNumbers n1, RationalNumbers n2)
        {
            RationalNumbers n = n1 / n2;
            return n.Numerator % n.Denominator;
        }
        public static bool operator >(RationalNumbers n1, RationalNumbers n2)
        {
            return n1.Numerator * n2.Denominator > n2.Numerator * n1.Denominator;
        }
        public static bool operator <(RationalNumbers n1, RationalNumbers n2)
        {
            return n1.Numerator * n2.Denominator < n2.Numerator * n1.Denominator;
        }
        public static bool operator ==(RationalNumbers n1, RationalNumbers n2)
        {
            return n1.Numerator * n2.Denominator == n2.Numerator * n1.Denominator;
        }
        public static bool operator !=(RationalNumbers n1, RationalNumbers n2)
        {
            return n1.Numerator * n2.Denominator != n2.Numerator * n1.Denominator;
        }
        public static bool operator >=(RationalNumbers n1, RationalNumbers n2)
        {
            return n1.Numerator * n2.Denominator >= n2.Numerator * n1.Denominator;
        }
        public static bool operator <=(RationalNumbers n1, RationalNumbers n2)
        {
            return n1.Numerator * n2.Denominator <= n2.Numerator * n1.Denominator;
        }
        public static explicit operator int(RationalNumbers n)
        {
            return (int)n.Numerator / n.Denominator;
        }
        public static explicit operator float(RationalNumbers n)
        {
            return (float)n.Numerator / n.Denominator;
        }
        public override bool Equals(object obj) //  Equals 
        {
            if (obj is RationalNumbers n)
            {
                return Numerator * n.Denominator == n.Numerator * Denominator;
            }
            else
            {
                return false;
            }
        }
        public override int GetHashCode() => base.GetHashCode();
        public override string ToString()
        {
            if (denominator == 1)
            {
                return $"{numerator}";
            }
            else
            {
                return $"{numerator}/{denominator}";
            }
        }
    }
}
