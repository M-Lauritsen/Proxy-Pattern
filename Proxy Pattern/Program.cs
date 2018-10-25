using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Pattern
{
    class Program
    {
        //The "Subject" interface
        public interface IMath
        {
            double Add(double x, double y);
            double Sub(double x, double y);
            double Mul(double x, double y);
            double Div(double x, double y);
        }

        // The "RealSubject class
        class Math : IMath
        {
            public double Add(double x, double y) { return x + y; }
            public double Sub(double x, double y) { return x - y; }
            public double Mul(double x, double y) { return x * y; }
            public double Div(double x, double y) { return x / y; }
        }

        // The "Proxy Object" class
        class MathProxy : IMath
        {
            private Math _math = new Math();

            public double Add(double x, double y)
            {
                return _math.Add(x, y);
            }
            public double Sub(double x, double y)
            {
                return _math.Sub(x, y);
            }
            public double Mul(double x, double y)
            {
                return _math.Mul(x, y);
            }
            public double Div(double x, double y)
            {
                return _math.Div(x, y);
            }
        }
        static void Main(string[] args)
        {
            // Create Math Proxy
            MathProxy proxy = new MathProxy();

            // Do the Math
            Console.WriteLine("4 + 2 = " + proxy.Add(4, 2));
            Console.WriteLine("4 - 2 = " + proxy.Sub(4, 2));
            Console.WriteLine("4 * 2 = " + proxy.Mul(4, 2));
            Console.WriteLine("4 / 2 = " + proxy.Div(4, 2));

            Console.ReadKey();

        }
    }
}
