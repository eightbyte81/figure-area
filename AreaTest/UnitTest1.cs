using AreaLibrary;

namespace AreaTest;

public class Tests
{
    [Test]
    public void TriangleWithoutValues()
    {
        var triangle = new Triangle();
        Assert.That(triangle.Area, Is.EqualTo(0));
    }
    
    [Test]
    public void TriangleWithValues()
    {
        var triangle = new Triangle(3, 4, 5);
        Assert.That(triangle.Area, Is.EqualTo(6));
    }
    
    [Test]
    public void IsTriangleRight()
    {
        var triangle = new Triangle(3, 4, 5);
        Assert.That(triangle.IsRight(), Is.True);
    }
    
    [Test]
    public void CircleWithoutValue()
    {
        var circle = new Circle();
        Assert.That(circle.Area, Is.EqualTo(0));
    }
    
    [Test]
    public void CircleWithValue()
    {
        var circle = new Circle(3);
        Assert.That(circle.Area, Is.EqualTo(28.274333882308138));
    }
    
    [Test]
    public void TriangleFigureWithoutValues()
    {
        var triangle = new Figure(new Triangle());
        Assert.That(triangle.Area, Is.EqualTo(0));
    }
    
    [Test]
    public void TriangleFigureWithValues()
    {
        var triangle = new Figure(new Triangle(3, 4, 5));
        Assert.That(triangle.Area, Is.EqualTo(6));
    }
    
    [Test]
    public void CircleFigureWithoutValue()
    {
        var circle = new Figure(new Circle());
        Assert.That(circle.Area, Is.EqualTo(0));
    }
    
    [Test]
    public void CircleFigureWithValue()
    {
        var circle = new Figure(new Circle(3));
        Assert.That(circle.Area, Is.EqualTo(28.274333882308138));
    }
}