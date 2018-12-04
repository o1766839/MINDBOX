using System;
using Mindbox.Interface;

namespace Mindbox.Figures
{
    public class Circle : IFigure
    {
        public Circle(double r)
        {
            R = r;
            D = r * 2d;
        }

        public double R { get; }
        public double D { get; }

        public double GetArea()
        {
            return Math.PI * R * R;
        }
    }
}
