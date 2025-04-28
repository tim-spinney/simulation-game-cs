namespace GuiComponents;

public class Row : AggregateComponent
{

    public Row(Rectangle boundingBox) : base(boundingBox)
    {
    }

    public override void Draw(IGraphics graphics)
    {
        int totalOffset = 0;
        foreach (Component component in components)
        {
            component.Draw(graphics);
            
        }
        graphics.OffsetX(-totalOffset);
    }

    public static Row CreateDemo()
    {
        Row row = new Row(new Rectangle());
        row.AddComponent(new TextLabel("Agree to terms and conditions", new Rectangle()));
        row.AddComponent(new CheckBox(new Rectangle()));
        return row;
    }
}