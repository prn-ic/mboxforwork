using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mindbox.ClassLibrary
{
    public class Triangle : IFigure
    {
        private double _a;
        private double _b;
        private double _c;

        public Triangle(double a, double b, double c)
        {
            _a = a;
            _b = b;
            _c = c;
        }
        public double SquareCalc()
        {
            if ((_c*_c) == ((_a * _a) + (_b * _b)))
            {
                Console.WriteLine("Этот треугольник прямоугольный!");
                return Math.Round(((0.5 * _a) * _b), 6);
            }
            else
            {
                var p = ((_a + _b + _c) / 2);
                var s = Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
                return Math.Round(s, 6);
            }
        }
    }
}
