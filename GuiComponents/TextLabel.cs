namespace GuiComponents;

public class TextLabel : Component
{
    private String _text;

    public TextLabel(String text, Rectangle boundingBox) : base(boundingBox)
    {
        _text = text;
    }

    public override void Draw(IGraphics graphics)
    {
        graphics.DrawText(_boundingBox.X, _boundingBox.Y, _text);
    }
}