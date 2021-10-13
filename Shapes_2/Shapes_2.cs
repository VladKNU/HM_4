using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_2
{
    abstract class Shapes_2
    {
        public abstract double GetArea();

        public abstract double GetPerimetr();
    }

    class Square : Shapes_2
    {
        double side;

        public Square(double a)
        {
            if (a > 0)
            {
                side = a;
            }
            else
                throw new Exception();
        }

        public override double GetArea() => side * side;

        public override double GetPerimetr() => 4 * side;
    }

    class Rectangle : Shapes_2
    {
        double first_side;
        double second_side;

        public Rectangle(double a, double b)
        {
            if (a > 0 && b > 0)
            {
                first_side = a;
                second_side = b;
            }
            else
                throw new Exception();
        }

        public override double GetArea() => first_side * second_side;

        public override double GetPerimetr() => (first_side + second_side) * 2;
    }

    class Rhomb : Shapes_2
    {
        double side;
        double corner;

        public Rhomb(double a, double alpha)
        {
            if(a > 0 && alpha != 0 && alpha != 180)
            {
                side = a;
                corner = alpha;
            }
            else
                throw new Exception();
        }

        public override double GetArea()
        {
            corner = Math.Sin((corner * Math.PI) / 180);
            return Math.Abs(Math.Pow(side, 2) * corner);
        }

        public override double GetPerimetr() => 4 * side;
    }

    class Triangle : Shapes_2
    {
        double first;
        double second;
        double third;

        public Triangle(double a, double b, double c)
        {
            if (a > 0 && b > 0 && c > 0
                && a + b > c
                && b + c > a
                && a + c > b)
            {
                first = a;
                second = b;
                third = c;
            }
            else
                throw new Exception();
        }

        public override double GetPerimetr()
        {
            return first + second + third;
        }

        public override double GetArea()
        {
            double p = (first + second + third) / 2;
            return Math.Sqrt(p * (p - first) * (p - second) + (p - third));
        }
    }

    class Circle : Shapes_2
    {
        double radius;

        public Circle(double r)
        {
            if (r > 0)
                radius = r;
            else
                throw new Exception();
        }

        public override double GetPerimetr()
        {
            return 2 * Math.PI * radius;
        }

        public override double GetArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

    }
}
