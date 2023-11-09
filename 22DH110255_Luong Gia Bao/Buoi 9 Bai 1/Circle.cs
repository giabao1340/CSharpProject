using System;
using System.Collections.Generic;
using System.Text;

namespace Shape
{
    internal class Circle: Shape
    {
        private double radius;
        public Circle()
        {
            this.radius = 1.5;
        }
        public Circle(double radius, string color, bool filled):base(color, filled)
        {
            this.radius = radius;
            this.color = color;
            this.filled = filled;
        }
        public double getRadius()
        {
            return radius;
        }
        public void setRadius(double radius)
        {
            this.radius = radius;
        }
        public override double getArea()
        {
            return Math.Round(Math.PI * radius * radius, 2);
        }
        public override double getPerimeter()
        {
            return Math.Round(Math.PI * radius * 2, 2);
        }
        public override string ToString()
        {
            //return $"{base.ToString()}  P = {getPerimeter().ToString("#,##0 m")}, S = {getArea().ToString("#,##0 m2")}";
            return $"Circle[P = {getPerimeter()}, S = {getArea()} {base.ToString()}]";

        }
    }
}
