using System;

class Point
{
    public double X, Y;

    public Point(double x, double y) { X = x; Y = y; }

    public static Point operator +(Point a, Point b)
    {
        return new Point(a.X + b.X, a.Y + b.Y);
    }

    public static bool operator ==(Point a, Point b)
    {
        return a.X == b.X && a.Y == b.Y;
    }

    public static bool operator !=(Point a, Point b)
    {
        return !(a == b);
    }

    public override bool Equals(object obj)
    {
        return obj is Point p && this == p;
    }

    public override int GetHashCode() { return HashCode.Combine(X, Y); }

    public override string ToString() { return $"({X}; {Y})"; }
}

class Program
{
    static void Main()
    {
        Point a = new Point(1, 2);
        Point b = new Point(3, 4);
        Point c = new Point(1, 2);
        Console.WriteLine($"a + b = {a + b}");
        Console.WriteLine($"a == c: {a == c}");
        Console.WriteLine($"a != b: {a != b}");
        Console.WriteLine($"a == b: {a == b}");
    }
}
