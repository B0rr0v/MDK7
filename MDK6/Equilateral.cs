using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDK6
{
    public class Equilateral : Triangle
    {
        public double Pl { get; set; }

        
        public Equilateral(double side) 
        {            
            A = side;
            B = side;
            C = side;           
        }

        public double Result()
        {
            double p = (A + B + C) / 2;
            Pl = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return Pl;
        }

    }
}
