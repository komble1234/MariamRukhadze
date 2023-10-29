using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Rectangle : Shape
{
    private double length, width;

    public Rectangle(double sideLength, double sideWidth)
    {
        if (sideLength <= 0 || sideWidth <= 0)
        {
            throw new ArgumentException("Invalid sides for a rectangle.");
        }

        length = sideLength;
        width = sideWidth;
    }

    public override double Perimeter()
    {
        return 2 * (length + width);
    }

    public override double Area()
    {
        return length * width;
    }
}
