namespace GuiComponents;

public abstract class Component
{
    protected Rectangle _boundingBox;

    public Component(Rectangle boundingBox)
    {
        _boundingBox = boundingBox;
    }
    
    public abstract void Draw(IGraphics graphics);

    public Component Demo()
    {
        Component c = new Row(_boundingBox);
        return c;
    }
}