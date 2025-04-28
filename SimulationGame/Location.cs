namespace SimulationGame;

public class Location
{
    private Rectangle bounds;

    public Location(Rectangle bounds)
    {
        this.bounds = bounds;
    }
    
    public Rectangle getBoundingBox()
    {
        return bounds;
    }
}

public readonly record struct Rectangle(int X, int Y, int Width, int Height)
{
}