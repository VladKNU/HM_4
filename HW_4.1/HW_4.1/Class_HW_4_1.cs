using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4._1
{
    public class Triangle
    {
        double first;
        double second;
        double third;

        public Triangle(double first_side, double second_side, double third_side)
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
            if(first_side > 0 && second_side > 0 && third_side > 0
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

    }
}
