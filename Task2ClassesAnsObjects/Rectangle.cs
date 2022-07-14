using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ClassesAndObjects
{

    class Rectangle
    {
        double side1, side2;
        double area, perimeter;

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;

        }
        double AreaCalculator()
        {
            return area = side1 * side2;
        }

        double PerimeterCalculator()
        {
            return perimeter = (side1 + side2) * 2;
        }
        public double Area { get { return AreaCalculator(); } }

        public double Perimeter { get { return PerimeterCalculator(); } }
    }
}