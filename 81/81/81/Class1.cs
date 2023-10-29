using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Triangle
{
    private double sideA;
    private double sideB;
    private double sideC;

    public Triangle(double a, double b, double c)
    {
        if (!IsValidTriangle(a, b, c))
        {
            throw new ArgumentException("Invalid triangle sides.");
        }

        sideA = a;
        sideB = b;
        sideC = c;
    }

    public double GetArea()
    {
        double s = (sideA + sideB + sideC) / 2;
        return Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
    }

    public double GetPerimeter()
    {
        return sideA + sideB + sideC;
    }

    public static bool operator ==(Triangle t1, Triangle t2)
    {
        if (ReferenceEquals(t1, t2)) return true;
        if (t1 is null || t2 is null) return false;
        return t1.sideA == t2.sideA && t1.sideB == t2.sideB && t1.sideC == t2.sideC;
    }

    public static bool operator !=(Triangle t1, Triangle t2)
    {
        return !(t1 == t2);
    }

    public static bool operator >(Triangle t1, Triangle t2)
    {
        return t1.GetArea() > t2.GetArea();
    }

    public static bool operator <(Triangle t1, Triangle t2)
    {
        return t1.GetArea() < t2.GetArea();
    }

    public static Triangle operator +(Triangle t1, Triangle t2)
    {
        double combinedArea = t1.GetArea() + t2.GetArea();
        double sideA = Math.Sqrt((combinedArea * 2) / Math.Sqrt(2));
        double sideB = sideA / Math.Sqrt(2);
        return new Triangle(sideA, sideB, sideB);
    }

    private bool IsValidTriangle(double a, double b, double c)
    {
        return a + b > c && a + c > b && b + c > a;
    }

    public static explicit operator Triangle(double sideLength)
    {
        if (sideLength <= 0)
        {
            throw new ArgumentException("Invalid side length for an equilateral triangle.");
        }

        return new Triangle(sideLength, sideLength, sideLength);
    }
}

