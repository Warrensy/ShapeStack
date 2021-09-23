using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bif3.Swe1.Oop.Polymorphism.OptimizedSolution
{
    class Triangle : Shape, IShapeComposition
    {
        private double _sideA, _sideB, _sideC, _heightA;
        public Triangle(int x, int y, double sideA, double sideB, double sideC, double heightA) : base(x, y)
        {
            _x = x;
            _y = y;
            _sideA = sideA;
            _sideB = sideB;
            _heightA = heightA;
        }
        public double GetArea()
        {
            return (_sideA * _heightA) / 2;
        }

        public double GetPerimeter()
        {
            return _sideA + _sideB + _sideC;
        }

        public void PrintShapeType()
        {
            Console.WriteLine("I'm a Triangle");
        }
    }
}
