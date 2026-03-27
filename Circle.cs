using System;
using System.Collections.Generic;
using System.Text;

namespace In_Class_Assignment_5
{
    internal class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle() : base() 
        {
            
        }

        public Circle(double radius) : base(color)
        {
            this.Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override string GetInfo()
        {
            return $"[Circle] Color: {Color}, Radius: {Radius}, Area: {GetArea():F2}";
        }
    }
}
