using System;
using System.Collections.Generic;
using System.Text;

namespace In_Class_Assignment_5
{
    public abstract class Shape : IShape
    {
        public string Color { get; set; }
        
        public Shape()
        {
            this.Color = "Unknown";
        }
        public Shape(string color)
        {
            this.Color = color;
        }

        public abstract double GetArea();
        public abstract string GetInfo();

    }
}
