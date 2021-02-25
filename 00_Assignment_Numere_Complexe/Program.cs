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
            Complex c1 = new Complex(6, 2);
            Complex c2 = new Complex(4, -3);
            Complex c3 = new Complex(3);
            Complex c4 = new Complex(0, -5);
            Complex c5 = new Complex("-25-6i");
            Complex c6 = c5.Add(c1);
            Complex c7 = c2.Multiply(c3);
            double a = c1.Modul(c1);
            Console.WriteLine(a);

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