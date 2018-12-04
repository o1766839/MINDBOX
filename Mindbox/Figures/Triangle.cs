using System;
using System.Collections.Generic;
using Mindbox.Interface;

namespace Mindbox.Figures
{
    public class Triangle : IFigure
    {
        private bool? _isRight;

        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public double A { get; }
        public double B { get; }
        public double C { get; }

        public bool IsRight
        {
            get
            {
                if (_isRight.HasValue)
                {
                    return _isRight.Value;
                }

                var sortedSides = new List<double> {A, B, C}; //Лень делать эффективно.
                sortedSides.Sort();
                _isRight = Math.Abs(sortedSides[0] * sortedSides[0] 
                    + sortedSides[1] * sortedSides[1] - sortedSides[2] * sortedSides[2]) 
                        < 0.00000001;
                return _isRight.Value;
            }
        }

        public double GetArea()
        {
            var p = (A + B + C) / 2d;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}
