using System;
using System.Collections.Generic;
using System.Text;

namespace Shape
{
    internal abstract class Shape
    {
        //attribute
        protected string color;
        protected bool filled;
        //constructor
        public Shape() { }
        public Shape(string color, bool filled)
        {
            this.color = color;
            this.filled = filled;
        }
        //method
        public string getColor()
        {
            return color;
        }
        public void setColor(string color)
        {
            this.color = color;
        }
        public bool isFilled()
        {
            return filled;
        }
        public void setFilled(bool filled)
        {
            this.filled = filled;
        }
        public abstract double getArea();
        public abstract double getPerimeter();
        public override string ToString()
        {
            return $"Color: {color}, Filled: {filled}";
        }
    }
}