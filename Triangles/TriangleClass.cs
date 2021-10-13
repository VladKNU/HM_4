using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangles
{
    public class TriangleClass
    {
        protected double first;
        protected double second;
        protected double third;

        protected TriangleClass() { }

        public TriangleClass(double first_side, double second_side, double third_side)
        {
            if (first_side > 0 && second_side > 0 && third_side > 0
                && first_side + second_side > third_side
                && second_side + third_side > first_side
                && first_side + third_side > second_side)
            {
                first = first_side;
                second = second_side;
                third = third_side;
            }
            else
                throw new Exception();
        }

        public bool ChangeSide(double first_side, double second_side, double third_side)
        {
            if (first_side > 0 && second_side > 0 && third_side > 0
                && first_side + second_side > third_side
                && second_side + third_side > first_side
                && first_side + third_side > second_side)
            {
                first = first_side;
                second = second_side;
                third = third_side;

                return true;
            }
            return false;
        }

        public double GetPerimetr()
        {
            return first + second + third;
        }

        public double GetAlpha()
        {
            double Alpha = (Math.Pow(second, 2) + Math.Pow(third, 2) - Math.Pow(first, 2)) / (2 * second * third);
            return (Math.Acos(Alpha) * 180) / (Math.PI);
        }

        public double GetBetta()
        {
            double Betta = (Math.Pow(first, 2) + Math.Pow(third, 2) - Math.Pow(second, 2)) / (2 * first * third);
            return (Math.Acos(Betta) * 180) / (Math.PI);
        }
        public double GetGamma()
        {
            double Gamma = (Math.Pow(first, 2) + Math.Pow(second, 2) - Math.Pow(third, 2)) / (2 * first * second);
            return (Math.Acos(Gamma) * 180) / (Math.PI);
        }
    }

    public class EquilTriangle : TriangleClass
    {
        public EquilTriangle(double first_side, double second_side, double third_side)
        {
            if (first_side > 0 && second_side > 0 && third_side > 0
                && first_side + second_side > third_side
                && second_side + third_side > first_side
                && first_side + third_side > second_side
                && first_side == second_side
                && second_side == third_side)
            {
                first = first_side;
                second = second_side;
                third = third_side;
            }
            else
                throw new Exception();
        }

        public double GetArea()
        {
            return (Math.Pow(first, 2) * Math.Sqrt(3)) / 4;
        }
    }
}
