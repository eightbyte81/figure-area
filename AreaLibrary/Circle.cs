namespace AreaLibrary;

public class Circle : IFigure
{
    public double Area => Math.PI * Radius * Radius;
    private double Radius { get; }
    
    public Circle()
    {
        Radius = default;
    }
    
    public Circle(double r)
    {
        Radius = r;
    }
}