using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDK6
{
    public class Triangle
    {

        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Triangle()
        {
            SetParams(0d, 0d, 0d);
        }

        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public void SetParams(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }


        public static bool operator true(Triangle triangle)
        {
            if (triangle.A + triangle.B > triangle.C && triangle.A + triangle.C > triangle.B && triangle.B + triangle.C > triangle.A) return true;
            else return false;
        }

        public static bool operator false(Triangle triangle)
        {
            return false;
        }
        public static Triangle operator ++(Triangle number)
        {
            number.A += 1;
            number.B += 1;
            number.C += 1;

            return number;
        }

        public static Triangle operator --(Triangle number)
        {
            number.A -= 1;
            number.B -= 1;
            number.C -= 1;

            return number;
        }
       
     
    }


}
