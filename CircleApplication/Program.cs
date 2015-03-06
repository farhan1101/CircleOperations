using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculateCircleRelatedOperation circleCalc = new CalculateCircleRelatedOperation();

            Console.WriteLine("Give the radius of the circle: ");
            
            double radius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("The Diameter of the circle is : " + circleCalc.GetDiameter(radius) + "\n");
            Console.WriteLine("The Perimeterr of the circle is : " + circleCalc.GetPerimeter(radius) + "\n");
            Console.WriteLine("The Area of the circle is : " + circleCalc.GetArea(radius)+ "\n");

            Console.ReadKey();



        }
    }
}
