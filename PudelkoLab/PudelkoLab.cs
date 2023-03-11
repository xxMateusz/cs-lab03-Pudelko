using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;

namespace PudelkoLab
{
    public sealed class Pudelko : IEquatable<Pudelko>, IFormattable, IEnumerable, IEnumerator<double>
    {
        public readonly double A;
        public readonly double B;
        public readonly double C;
        public readonly UnitOfMeasure Unite;

        private double CheckValues (double a, double b, double c) 
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentOutOfRangeException();

            if (a > 10 || b > 10 || c > 10)
                throw new ArgumentOutOfRangeException();
        }
        public string Pudelko(double a = 0.1, double b = 0.1, double c = 0.1, UnitOfMeasure unite = UnitOfMeasures.meter) 
        {
            A = a;
            B = b; 
            C = c;
            Unite = unite;
            CheckValues (A, B, C);
        }
        public string ToString()
        private double Objetosc ()
        {
         
            double O = A * B * C;

            return $"{Math.Round(O), 9)} m3";
        }
        private double Pole()
        {
            
            double P = 2 * A * B + 2 * A * C + 2 * B * C, 6
            return $"{Math.Round(2 * A * B + 2 * A * C + 2 * B * C, 6)} m2";
        }
        public override string ToString()
        {
            return $"{A.ToString("F3")} m \u00D7 {B.ToString("F3")} m \u00D7 {C.ToString("F3")} m";
        }
        public string ToString(string format, IFormatProvider formatProvider = null    )
        {
            if( format == null )
            {
                format = "m";

            }
            switch (format)
            {
                case "m":
                    return ToString();
                case "cm":
                    return $"{(A * 100).ToString("F1")} cm \u00D7 {(B * 100).ToString("F1")} cm \u00D7 {(C * 100).ToString("F1")} cm";
                case "mm":
                    return $"{A * 1000} mm \u00D7 {B * 1000} mm \u00D7 {C * 1000} mm";
                default:
                    throw new FormatException();
            }

        }
    }


}