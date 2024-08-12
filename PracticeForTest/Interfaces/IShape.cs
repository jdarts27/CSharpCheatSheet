using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeForTest
{
    public interface IShape
    {
        string Name { get; set; }
        void printName();
        void printDescription();
    }
}
