using System;
using System.Numerics;

namespace lab_4
{
    class Program
    {
        static void testAPlusBSquare1<T>(T a, T b) where T : IMyNumber<T>
        {
            Console.WriteLine("=== Starting testing (a+b)^2=a^2+2ab+b^2 with a = " + a + ", b = " + b + " ===");
            T aPlusB = a.Add(b);
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("(a + b) = " + aPlusB);
            Console.WriteLine("(a+b)^2 = " + aPlusB.Multiply(aPlusB));
            Console.WriteLine(" = = = ");
            T curr = a.Multiply(a);
            Console.WriteLine("a^2 = " + curr);
            T wholeRightPart = curr;
            curr = a.Multiply(b);
            curr = curr.Add(curr);
            Console.WriteLine("2*a*b = " + curr);
            wholeRightPart = wholeRightPart.Add(curr);
            curr = b.Multiply(b);
            Console.WriteLine("b^2 = " + curr);
            wholeRightPart = wholeRightPart.Add(curr);
            Console.WriteLine("a^2+2ab+b^2 = " + wholeRightPart);

            Console.WriteLine("a/b: ");
            T aDivideb = a.Divide(b);
            Console.WriteLine("a/b = " + aDivideb);
            Console.WriteLine("a-b: ");
            T aMinusb = a.Subtract(b);
            Console.WriteLine("a-b = " + aMinusb);
            Console.WriteLine("=== Finishing testing (a+b)^2=a^2+2ab+b^2 with a = " + a + ", b = " + b + " ===");

        }
        static void testAPlusBSquare2<T>(T a, T b) where T : IMyNumber<T>
        {
            T aPlusB = a.Add(b);
            Console.WriteLine("z_1 = " + a);
            Console.WriteLine("z_2 = " + b);
            Console.WriteLine("Testing (z_1 + z_2) = " + aPlusB);
            Console.WriteLine("Testing ( z_1 + z_2)^2 = " + aPlusB.Multiply(aPlusB));
            Console.WriteLine("Testing ( z_1 - z_2) = " + a.Subtract(b));
            Console.WriteLine("Testing ( z_1/z_2) = " + a.Divide(b));
        }

        static void Main(string[] args)
        {
            Frac a = new Frac(-12, 3);
            Frac b = new Frac(1, 6);

            testAPlusBSquare1(a, b);
            MyComplex z_1 = new MyComplex(5, -6);
            MyComplex z_2 = new MyComplex(-3, 2);

            testAPlusBSquare2(z_1, z_2);

            Console.ReadKey();
        }
    }
}

