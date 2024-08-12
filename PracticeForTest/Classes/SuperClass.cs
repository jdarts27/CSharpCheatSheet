using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeForTest
{
    // SuperClass => rectangle
    public class SuperClass : IShape
    {
        private double _length;
        private double _width;

        public SuperClass()
        {
            _length = 0;
            _width = 0;
            Name = "No Name";
        }

        public SuperClass(string name, int len, int wid)
        {
            this._length = len;
            this._width = wid;
            this.Name = name;
        }

        public double Length { get; set; }
        public double Width { get; set; }
        public string Name { get; set; }

        public virtual double calculateArea()
        {
            return Length * Width;
        }

        public virtual void printDescription()
        {
            Console.WriteLine("Length: {0}, Width: {1}", Length, Width);
        }

        public void printName()
        {
            Console.WriteLine(Name);
        }
    }
}
