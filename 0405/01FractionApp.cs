using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Fraction
    {
        int numerator;  //분자필드
        int denominator; ///문모필드

        public Fraction(int num, int denom)
        {
            //생성자
            numerator = num;
            denominator = denom;
        }

        public void PrintFraction()
        {
            //출력메소드
            Console.WriteLine(numerator + "/" + denominator);
        }
    }

    class FractionApp
    {
        static void Main(string[] args)
        {
            Fraction f = new Fraction(1, 2);
            f.PrintFraction();
        }
    }
}
