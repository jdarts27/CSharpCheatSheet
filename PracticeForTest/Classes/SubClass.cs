using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeForTest
{
    // SubClass => triangle
    public class SubClass : SuperClass
    {
        public SubClass(string name, int len, int wid) : base(name, len, wid)
        {
            Length = len;
            Width = wid;
            this.Name = name;
        }

        public static double calculateArea(double len, double wid)
        {
            return len * wid / 2;
        }

        public override double calculateArea()
        {
            return calculateArea(Length, Width);
        }
    }
}
