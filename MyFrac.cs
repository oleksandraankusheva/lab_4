using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace lab4
{
    class MyFrac : IMyNumber<MyFrac>
    {
        private BigInteger nom;
        private BigInteger denom;

        public MyFrac(BigInteger nom, BigInteger denom)
        {
            this.nom = nom;
            this.denom = denom;
            Simplify();
        }

        public MyFrac(int nom, int denom)
        {
            this.nom = nom;
            this.denom = denom;
            Simplify();
        }
        private void Simplify()  //спрощення
        {
            BigInteger gcd = GCD(nom, denom);
            if (gcd > 1)
            {
                nom /= gcd;
                denom /= gcd;
            }
        }

        private BigInteger GCD(BigInteger a, BigInteger b) //найбільше спільне кратне
        {
            while (b != 0)
            {
                BigInteger temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public MyFrac Add(MyFrac that)
        {
            BigInteger a = this.nom;
            BigInteger b = this.denom;
            BigInteger c = that.nom;
            BigInteger d = that.denom;
            BigInteger ad = BigInteger.Multiply(a, d);
            BigInteger bc = BigInteger.Multiply(b, c);
            BigInteger ad_plus_bc = BigInteger.Add(ad, bc);
            BigInteger bd = BigInteger.Multiply(b, d);
            if (bd.IsZero)
            {
                throw new DivideByZeroException();
            }
            return new MyFrac(ad_plus_bc, bd);
        }

        public MyFrac Subtract(MyFrac that)
        {
            BigInteger a = this.nom;
            BigInteger b = this.denom;
            BigInteger c = that.nom;
            BigInteger d = that.denom;
            BigInteger ad = BigInteger.Multiply(a, d);
            BigInteger bc = BigInteger.Multiply(b, c);
            BigInteger ad_minus_bc = BigInteger.Subtract(ad, bc);
            BigInteger bd = BigInteger.Multiply(b, d);
            if (bd.IsZero)
            {
                throw new DivideByZeroException();
            }
            return new MyFrac(ad_minus_bc, bd);
        }

        public MyFrac Multiply(MyFrac that)
        {
            BigInteger a = this.nom;
            BigInteger b = this.denom;
            BigInteger c = that.nom;
            BigInteger d = that.denom;
            BigInteger ac = BigInteger.Multiply(a, c);
            BigInteger bd = BigInteger.Multiply(b, d);
            if (bd.IsZero)
            {
                throw new DivideByZeroException();
            }
            return new MyFrac(ac, bd);
        }

        public MyFrac Divide(MyFrac that)
        {
            BigInteger a = this.nom;
            BigInteger b = this.denom;
            BigInteger c = that.nom;
            BigInteger d = that.denom;
            BigInteger ad = BigInteger.Multiply(a, d);
            BigInteger bc = BigInteger.Multiply(b, c);
            if (bc.IsZero)
            {
                throw new DivideByZeroException();
            }
            return new MyFrac(ad, bc);
        }

        public override string ToString()
        {
            return $"{nom}/{denom}";
        }
    }
}
