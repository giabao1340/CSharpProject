using System;
using System.Collections.Generic;
using System.Text;

namespace Shape
{
        internal class Rectangle: Shape
    {
        //Attribute
        protected double width;
        protected double length;
        //constructor
        public Rectangle() { }
        public Rectangle(double width, double length)
        {
            this.width = width;
            this.length = length;
        }
        public Rectangle(double width, double length, string color, bool filled): base(color, filled)
        {
            this.width = width;
            this.length = length;
        }

        public double getWidth()
        {
            return width;
        }
        public virtual void setWidth(double width)
        {
            this.width = width;
        }
        public virtual double getLength()
        {
            return length;
        }
        public virtual void setLength(double length)
        {
            this.length = length;
        }
        public override double getArea()
        {
            return Math.Round(width*length, 2);
        }
        public override double getPerimeter()
        {
            return Math.Round((width + length) * 2, 2);
        }
        public override string ToString()
        {
            return $"Rectangle[P = {getPerimeter().ToString("#,##0 m")}, S = {getArea().ToString("#,##0 m2")} {base.ToString()}]";
        }
    }
}
