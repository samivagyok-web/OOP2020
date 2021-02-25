using System;
using System.Text.RegularExpressions;

namespace _00_Assignment_Numere_Complexe
{
    class Complex
    {
        private double re;
        private double im;

        public Complex(double re) : this(re, 0)
        {
           
        }

        public Complex(string v)
        {
            Regex.Replace(v, @"\s+", "");

            Regex realPattern = new Regex(@"^(-|\+|)\d*");           
            if (realPattern.IsMatch(v))
            {
                MatchCollection realMatches = realPattern.Matches(v);
                this.re = double.Parse(realMatches[0].ToString());
            }

            Regex imagPattern = new Regex(@"(\+|-)\d*(?=\s*i)");
            if (realPattern.IsMatch(v))
            {
                MatchCollection imagMatches = imagPattern.Matches(v);
                this.im = double.Parse(imagMatches[0].ToString());
            }
        }

        public Complex(double re, double im)
        {
            this.re = re;
            this.im = im;
        }

        public override string ToString() 
        {
            string semn2 = "";

            if (re == 0)
            {
                if (im == 0)
                    return "0";
                else
                    return im.ToString() + "i";
            }

            if (im < 0)
            {
                im = -im;
                semn2 = "-";
            }
            else if (im > 0)
                semn2 = "+";
            else
                return re.ToString();

            return "(" + (re.ToString()) + " " + semn2 + " " + im.ToString() + "i" + ")";
        }

        public Complex Add(Complex c2) => new Complex(re + c2.re, im + c2.im);
        public Complex Substract(Complex c2) => new Complex(re - c2.re, im - c2.im);
        public Complex Multiply(Complex c2) => new Complex((re * c2.re) - (im * c2.im), (re * c2.im) + (c2.re * im));


        public double Re
        {
            get
            {
                return re;
            }
        }

        public double Imag
        {
            get
            {
                return im;
            }
        }

        public double Modul(Complex c) => Math.Sqrt(Math.Pow(re, 2) + Math.Pow(im, 2));
        public double Argument(Complex c) => Math.Atan(im / re);
    
        // TODO
        // orice alte operatii ce stiu
    }
}