namespace polymorphism;

public class Circle : Shape
{
    override public void Draw()
    {
        Console.WriteLine("Draw a circle");
        //base.Draw();
    }
}

public class Retangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Draw a rectangle");
        //base.Draw();
    }
}


public class Shape
{
    public int Wdth { get; set; }
    public int Height { get; set; }
    public Position? Position { get; set; }
    public virtual void Draw()
    {

    }

}

