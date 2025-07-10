using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Penghitung_luas_bangun_datar
{
    public class Square : Shape
    {
        public double Side { get; set; }

        public Square(double side)
        {
            Side = side;
        }

        public override double CalculateArea()
        {
            return Side * Side;
        }
    }

}
