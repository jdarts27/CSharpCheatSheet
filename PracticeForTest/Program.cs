using System;

namespace PracticeForTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            SuperClass superClass = new SuperClass("Basic Shape", 4, 5);
            SubClass subClass = new SubClass("Triangle", 10, 6);
            DifferentShape differentShape = new DifferentShape("Cube", 6, 5, 4);


            superClass.printName();
            superClass.printDescription();
            Console.WriteLine(superClass.calculateArea());
            subClass.printName();
            subClass.printDescription();
            Console.WriteLine(subClass.calculateArea());
            differentShape.printName();
            differentShape.printDescription();
            Console.WriteLine(differentShape.calculateArea());

            Console.WriteLine("\nArea of triangle using static method(6, 7): {0}", SubClass.calculateArea(6, 7));
        }
    }
}