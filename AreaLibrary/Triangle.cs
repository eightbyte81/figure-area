namespace AreaLibrary;

public class Triangle : IFigure
{
    public double Area { get; }
    private double SideA { get; }
    private double SideB { get; }
    private double SideC { get; }

    public bool IsRight()
    {
        return SideA.CompareTo(Math.Sqrt(SideB * SideB + SideC * SideC)) == 0 ||
               SideB.CompareTo(Math.Sqrt(SideA * SideA + SideC * SideC)) == 0 ||
               SideC.CompareTo(Math.Sqrt(SideA * SideA + SideB * SideB)) == 0;
    }

    public Triangle()
    {
        SideA = SideB = SideC = default;
    }

    public Triangle(double a, double b, double c)
    {
        SideA = a;
        SideB = b;
        SideC = c;
        
        var p = (a + b + c) / 2;
        Area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }
}