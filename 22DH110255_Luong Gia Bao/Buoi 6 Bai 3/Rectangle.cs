using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    internal class Rectangle
    {
        //Atribute 
        private double  width;
        private double height;
        //Properties
        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        public double Height
        {
            get { return height; }
            set { Height = value; }
        }
        //Constructor
        public Rectangle() { }
        public Rectangle(double width, double height)
        {
            if (width <= 0)
            {
                do
                {
                    Console.Write("Nhap chieu rong > 0: ");
                    width = double.Parse(Console.ReadLine());
                } while (width <= 0);
            } 
                this.width = width;
            if (height <= 0)
            {

                do
                {
                    Console.Write("Nhap chieu dai > 0: ");
                    height = double.Parse(Console.ReadLine());

                } while (height <= 0);
            }
                this.height = height;
        }



        //Method
        public void Input()
        {
            do
            {
                Console.Write("Nhap chieu rong > 0: ");
                this.width = double.Parse(Console.ReadLine());
            } while (width <= 0);


            do
            {
                Console.Write("Nhap chieu dai > 0: ");
                this.height = double.Parse(Console.ReadLine());

            } while (height <= 0);

        }
        public override string ToString()
        {
            return $"P = {GetPerimeter()} S = {GetArea()}";
        }
        public double GetPerimeter()
        {
            return (double) (width + height)/2;
        }
        public double GetArea()
        { 
            return width * height;
        }
        public bool IsSameArea(Rectangle rect) 
        {
            double oldArea = Width * Height;
            double newArea = rect.Width * rect.Height;
            if (oldArea == newArea)
            {
                return true;
            }
            return false;
        }
    }
}
