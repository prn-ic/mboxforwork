using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mindbox.ClassLibrary
{
    public class Circle: IFigure
    {
        private double value;
        public Circle(double value) {
            this.value = value;
        }
        public double SquareCalc()
        {
            return Math.Round(Math.PI * (value*value), 6);
        }
    }
}
