
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the figure type:");
        Console.WriteLine("1 - Triangle");
        Console.WriteLine("2 - Rectangle");
        Console.WriteLine("3 - Circle");

        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("Enter the three sides of the triangle (a, b, c):");
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());
                double sideC = double.Parse(Console.ReadLine());
                try
                {
                    Shape triangle = new Triangle(sideA, sideB, sideC);
                    PrintResult(triangle);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
                break;

            case 2:
                Console.WriteLine("Enter the length and width of the rectangle (a, b):");
                double length = double.Parse(Console.ReadLine());
                double width = double.Parse(Console.ReadLine());
                try
                {
                    Shape rectangle = new Rectangle(length, width);
                    PrintResult(rectangle);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
                break;

            case 3:
                Console.WriteLine("Enter the radius of the circle (r):");
                double radius = double.Parse(Console.ReadLine());
                try
                {
                    Shape circle = new Circle(radius);
                    PrintResult(circle);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
                break;

            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }

    static void PrintResult(Shape shape)
    {
        Console.WriteLine($"Perimeter: {shape.Perimeter()}");
        Console.WriteLine($"Area: {shape.Area()}");
    }
}
