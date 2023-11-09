using System;
using System.Collections.Generic;
using System.Text;

namespace Shape
{
    internal class Square : Rectangle
    {
        private double side;
        public Square() { }
        public Square(double side):base(side,side)
        {
            this.side = side;
        }
        public Square(double side, string color, bool filled):base(side,side,color,filled)
        {
            this.side = side;
        }
        public double getSide()
        {
            return side;
        }
        public void setSide(double side)
        {
            this.side = side;
        }
        public override void setWidth(double width)
        {
            this.width = width;
        }
        public override void setLength(double length)
        {
            this.length = length;
        }
        public override double getArea()
        {
            return Math.Round(side*4, 2);
        }
        public override double getPerimeter()
        {
            return Math.Round(side*side, 2);
        }
        public override string ToString()
        {
            return $"Square[P = {getPerimeter().ToString("#,##0 m")}, S = {getArea().ToString("#,##0 m2")} {base.ToString()}";
        }
    }
}