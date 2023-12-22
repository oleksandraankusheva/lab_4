using System;
using System.Numerics;

namespace lab_4
{
    class MyComplex : IMyNumber<MyComplex>
    {
        private double re;
        private double im;

        public MyComplex(double re, double im)
        {
            this.re = re;
            this.im = im;
        }

        public MyComplex Add(MyComplex that)
        {
            return new MyComplex(this.re + that.re, this.im + that.im);
        }

        public MyComplex Subtract(MyComplex that)
        {
            return new MyComplex(this.re - that.re, this.im - that.im);
        }
        public MyComplex Multiply(MyComplex that)
        {
            double a = this.re;
            double b = this.im;
            double c = that.re;
            double d = that.im;
            double ac = a * c;
            double bd = b * d;
            double ad = a * d;
            double bc = b * c;
            return new MyComplex(ac - bd, ad + bc);
        }

        public MyComplex Divide(MyComplex that)
        {
            double a = this.re;
            double b = this.im;
            double c = that.re;
            double d = that.im;
            double ac = a * c;
            double bd = b * d;
            double ad = a * d;
            double bc = b * c;
            double c_2plusd_2 = c * c + d * d;
            if (c_2plusd_2 == 0)
            {
                throw new DivideByZeroException();
            }
            return new MyComplex((ac + bd) / c_2plusd_2, (bc - ad) / c_2plusd_2);
        }

        public override string ToString()
        {
            if (this.im > 0)
            {
                return $"{this.re}+{this.im}i";
            }
            else if (this.im == 0)
            {
                return $"{this.re}";
            }
            return $"{this.re}{this.im}i";
        }
    }
}