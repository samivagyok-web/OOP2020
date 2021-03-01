using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Assignment_Numere_Complexe
{
    class Program
    {
        static void Main(string[] args)
        {
        //   Complex c1 = new Complex(0, 4);
        //   Complex c2 = new Complex(4, -3);
        //   Complex c3 = new Complex(3);
        //   Complex c4 = new Complex(0, -5);
            Complex c5 = new Complex("+2i");
          Complex a = new Complex("3");
          Complex b = new Complex("-23 - 2i");
          Complex c = new Complex("4 + 7i");
          Complex d = new Complex("9 - 8i");
            Complex e = new Complex("0 - 8i");
            Complex f = new Complex("9 - 0i");
            //  Complex c6 = c5.Add(c1);
            //  Complex c7 = c2.Multiply(c3);
            //  double a = c1.Modul(c1);
            Console.WriteLine(c5);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);

            //Console.WriteLine(c7);
            // TODO: overloading operators
            // Complex suma = c1 + c2;

            //    Complex suma = c1.Add(c2);
            //    Console.WriteLine($"{c1} + {c2} = {suma}");
            //
            //    Complex subtract = c1.Substract(c2);
            //
            //    Complex mult = c1.Multiply (c2);
        }
    }
}