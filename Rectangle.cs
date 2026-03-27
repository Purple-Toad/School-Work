using System;
using System.Collections.Generic;
using System.Text;

namespace In_Class_Assignment_5
{
    internal class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle() : base()
        {

        }

        public Rectangle(double width, double height) : base(color)
        {
            this.Width = width;
            this.Height = height;
        }

        public override double GetArea()
        {
            return Width * Height;
        }

        public override string GetInfo()
        {
            return $"[Rectangle] Color: {Color}, Width: {Width}, Height: {Height}, Area: {GetArea():F2}";
        }
    }
}
