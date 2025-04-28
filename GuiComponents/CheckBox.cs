namespace GuiComponents;

public class CheckBox : Component
{
    private bool _isChecked;

    public CheckBox(Rectangle boundingBox) : base(boundingBox)
    {
    }

    public override void Draw(IGraphics graphics)
    {
        graphics.DrawRectangle(_boundingBox.X, _boundingBox.Y, _boundingBox.Width, _boundingBox.Height);
        // TODO: draw a line from mid-left to bottom-center, then bottom-center to top right for ✅
        //graphics.DrawLine(_boundingBox.X + 1, _boundingBox.Y + 1, _boundingBox.X, _boundingBox.Y + 1);
    }
}