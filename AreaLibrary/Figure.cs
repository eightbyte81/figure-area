namespace AreaLibrary;

public class Figure : IFigure
{
    public double Area { get; }

    public Figure(IFigure figure)
    {
        Area = figure.Area;
    }
}