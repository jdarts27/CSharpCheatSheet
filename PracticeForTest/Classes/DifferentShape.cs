using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeForTest
{
    // DifferentShape => Cube
    internal class DifferentShape : SuperClass
    {
        private double _height;
        public DifferentShape(string name, int len, int wid, int height) : base(name, len, wid)
        {
            Name = name;
            Length = len;
            Width = wid;
            _height = height;
        }

        public double Height { get; set; }

        public static double calculateArea(double len, double wid, double height)
        {
            return len * wid * height;
        }

        public override double calculateArea()
        {
            return calculateArea(Length, Width, Height);
        }

        public override void printDescription()
        {
            Console.WriteLine("Lenght: {0}, Width: {1}, Height: {2}", Length, Width, Height);
        }
    }
}
