using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangles_2
{
    public abstract class Triangles2Class
    {
        protected double first;
        protected double second;
        protected double angel;

        public virtual double GetPerimetr()
        {
            double third = Math.Sqrt(Math.Pow(first, 2) + Math.Pow(second, 2) - 2 * first * second * Math.Cos(angel));
            return first + second + third;
        }
        public virtual double GetArea()
        {
            double third = Math.Sqrt(Math.Pow(first, 2) + Math.Pow(second, 2) - 2 * first * second * Math.Cos(angel));
            double p = (first + second + third) / 2;
            return Math.Sqrt(p * (p - first) * (p - second) + (p - third));
        }

    }

    public class RightTriangle : Triangles2Class
    {
        double third;
        public RightTriangle(double a, double b, double c)
        {
            if (a > 0 && b >0)
            {
                first = a;
                second = b;
                angel = c;
                third = Math.Sqrt(Math.Pow(first, 2) + Math.Pow(second, 2) - 2 * first * second * Math.Cos(angel));
                third = Math.Round(third, MidpointRounding.ToEven);
            }
            else
                throw new Exception();
        }

        public override double GetPerimetr()
        {
            if (angel == 90)
                return 2 * first + third;
            else
               return  first + second + third;
        }

        public override double GetArea()
        {
            if (angel == 90)
                return (first * second) / 2;
            else if (first > second)
                return (second * third) / 2;
            else
                return (first * third);
                
        }
    }

    public class IsoscelesTriangle : Triangles2Class
    {
        double first;
        double second;
        double third;
        double angel;

        public IsoscelesTriangle(double a, double b, double c)
        {
            if (a > 0 && b > 0)
            {
                first = a;
                second = b;
                angel = c;
                third = Math.Sqrt(Math.Pow(first, 2) + Math.Pow(second, 2) - 2 * first * second * Math.Cos(angel));
                third = Math.Round(third, MidpointRounding.ToEven);
            }
            else
                throw new Exception();
        }

        public override double GetPerimetr()
        {
            if (first == second)
                return 2 * first + third;
            else
                return first + second + third;
        }

        public override double GetArea()
        {
            if (first == second)
                return Math.Abs((Math.Pow(first, 2) * Math.Sin(angel)) / 2);
            else
                return Math.Abs((Math.Pow(second, 2) * Math.Sin(angel)) / 2);
        }
    }
}
