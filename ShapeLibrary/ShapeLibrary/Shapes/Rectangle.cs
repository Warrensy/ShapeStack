using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bif3.Swe1.Oop.Polymorphism.OptimizedSolution;

namespace Bif3.Swe1.Oop.Polymorphism.OptimizedSolution
{
    class Rectangle : Shape, IShapeComposition
    {
        private double _sideA, _sideB;
        private int _x, _y;

        public Rectangle(int x, int y, double sideA, double sideB) : base(x, y)
        {
            _x = x;
            _y = y;
            _sideA = sideA;
            _sideB = sideB;
        }
        double IShapeMath.GetArea()
        {
            return _sideA * _sideB;
        }

        double IShapeMath.GetPerimeter()
        {
            return 2 * (_sideA * _sideB);
        }

        void IShape.PrintShapeType()
        {
            Console.WriteLine("I'm a Rectangle");
        }
    }
}
