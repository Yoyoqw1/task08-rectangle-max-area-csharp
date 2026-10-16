using System;

class Rectangle
{
    public double Width, Height;

    public Rectangle(double w, double h) { Width = w; Height = h; }

    public double GetArea() { return Width * Height; }
}

class Program
{
    static void Main()
    {
        Rectangle[] rects =
        {
            new Rectangle(2, 3),
            new Rectangle(4, 5),
            new Rectangle(1, 10),
            new Rectangle(6, 4),
            new Rectangle(3, 3)
        };

        Rectangle max = rects[0];
        for (int i = 1; i < rects.Length; i++)
        {
            if (rects[i].GetArea() > max.GetArea())
                max = rects[i];
        }
        Console.WriteLine($"Найбільша площа: {max.Width} x {max.Height} = {max.GetArea()}");
    }
}
