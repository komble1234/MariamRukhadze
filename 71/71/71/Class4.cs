using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Circle : Shape
{
    private double radius;

    public Circle(double circleRadius)
    {
        if (circleRadius <= 0)
        {
            throw new ArgumentException("Invalid radius for a circle.");
        }

        radius = circleRadius;
    }

    public override double Perimeter()
    {
        return 2 * Math.PI * radius;
    }

    public override double Area()
    {
        return Math.PI * radius * radius;
    }
}
