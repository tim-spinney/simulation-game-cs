namespace SimulationGame;

public class Residence : Location
{
    private readonly uint maxCapacity;
    private HashSet<Person> residents = new();
    private Inventory inventory = new();

    public Residence(uint maxCapacity, Rectangle bounds)
    : base(bounds)
    {
        this.maxCapacity = maxCapacity;
    }

    public void MovePersonIn(Person person)
    {
        if (residents.Count < maxCapacity)
        {
            residents.Add(person);
        }
    }

    public void MovePersonOut(Person person)
    {
        residents.Remove(person);
    }

    public bool TryTransferInventory(ItemType itemType, int quantity)
    {
        return inventory.TryAdjustQuantity(itemType, quantity);
    }
}