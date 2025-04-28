namespace GuiComponents;

public abstract class AggregateComponent : Component
{
    protected List<Component> components = new();
    
    public void AddComponent(Component component)
    {
        components.Add(component);
    }

    protected AggregateComponent(Rectangle boundingBox) : base(boundingBox)
    {
    }
}