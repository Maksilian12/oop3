using System;

class Point
{
    private double x;
    private double y;
    private string name;

    public Point(double x, double y, string name)
    {
        this.x = x;
        this.y = y;
        this.name = name;
    }

    public double X
    {
        get { return x; }
    }

    public double Y
    {
        get { return y; }
    }

    public string Name
    {
        get { return name; }
    }
}

class Figure
{
    private Point[] points;

    public Figure(Point point1, Point point2, Point point3)
    {
        points = new Point[3];
        points[0] = point1;
        points[1] = point2;
        points[2] = point3;
    }

    public Figure(Point point1, Point point2, Point point3, Point point4)
    {
        points = new Point[4];
        points[0] = point1;
        points[1] = point2;
        points[2] = point3;
        points[3] = point4;
    }

    public Figure(Point point1, Point point2, Point point3, Point point4, Point point5)
    {
        points = new Point[5];
        points[0] = point1;
        points[1] = point2;
        points[2] = point3;
        points[3] = point4;
        points[4] = point5;
    }

    private double GetSideLength(Point A, Point B)
    {
        return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
    }

    public void CalculatePerimeter()
    {
        double perimeter = 0;

        for (int i = 0; i < points.Length - 1; i++)
        {
            perimeter += GetSideLength(points[i], points[i + 1]);
        }

        perimeter += GetSideLength(points[points.Length - 1], points[0]);

        Console.WriteLine($"Периметр багатокутника: {perimeter}");
    }
}

class Program
{
    static void Main()
    {
        // Створення об'єктів класу Point для представлення вершин багатокутника
        Point A = new Point(0, 0, "A");
        Point B = new Point(4, 0, "B");
        Point C = new Point(4, 3, "C");
        Point D = new Point(2, 5, "D");
        Point E = new Point(0, 3, "E");

        // Створення об'єкта класу Figure з вершинами багатокутника
        Figure figure = new Figure(A, B, C, D, E);

        // Розрахунок та виведення периметра багатокутника
        figure.CalculatePerimeter();

        Console.ReadKey();
    }
}
