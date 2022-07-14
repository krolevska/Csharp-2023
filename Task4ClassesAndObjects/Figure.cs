using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4ClassesAndObjects
{
    class Figure
    {

        public Figure(Point a, Point b, Point c)
        {
            string abc = "triangle";
        }
        public Figure(Point a, Point b, Point c, Point d)
        {
            string abcd = "square";
        }
        public Figure(Point a, Point b, Point c, Point d, Point e)
        {
            string abcde = "pentangle";
        }

        public double LengthSide(Point A, Point B)
        {
            A = new Point();

        }
    }
}
