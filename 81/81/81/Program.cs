class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter the sides of a triangle (a, b, c):");
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());
            double sideC = double.Parse(Console.ReadLine());

            Triangle triangle = new Triangle(sideA, sideB, sideC);

            Console.WriteLine("Triangle created:");
            Console.WriteLine($"Area: {triangle.GetArea()}");
            Console.WriteLine($"Perimeter: {triangle.GetPerimeter()}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

        try
        {
            Console.WriteLine("Enter the side length for an equilateral triangle:");
            double sideLength = double.Parse(Console.ReadLine());

            Triangle equilateralTriangle = (Triangle)sideLength;

            Console.WriteLine("Equilateral Triangle created:");
            Console.WriteLine($"Area: {equilateralTriangle.GetArea()}");
            Console.WriteLine($"Perimeter: {equilateralTriangle.GetPerimeter()}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
