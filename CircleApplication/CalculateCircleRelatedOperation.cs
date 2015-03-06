using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleApplication
{
    class CalculateCircleRelatedOperation
    {
        public double Diameter { set; get; }
        public double Perimeter { set; get; }

        public double Area { set; get; }

        public double GetDiameter(double radius)
        {
            Diameter = radius*2;
            return Diameter;
        }

        public double GetPerimeter(double radius)
        {
            return Perimeter = 2*Math.PI*radius;
        }

        public double GetArea(double radius)
        {
            return Area = Math.PI*Math.Pow(radius, 2);
        }

    }
}
