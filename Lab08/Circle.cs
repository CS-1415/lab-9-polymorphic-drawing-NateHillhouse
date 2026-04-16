using System.Runtime.CompilerServices;

namespace Lab08;

public class Circle : AbstractGraphic2D
{
    public override decimal LowerBoundX => CenterX - Radius;

    public override decimal UpperBoundX => CenterX + Radius;

    public override decimal LowerBoundY => CenterY - Radius;

    public override decimal UpperBoundY => CenterY + Radius;

    public int CenterX;
    public int CenterY;
    public int Radius;

    public Circle(int x, int y, int radius)
    {
        CenterX = x;
        CenterY = y;
        Radius = radius;

    }

    public override bool ContainsPoint(decimal x, decimal y)
    {
        return (x == CenterX) && (y == CenterY);
    }
}