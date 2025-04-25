namespace SimulationGame;

public enum ItemType
{
    Food
}

public class Inventory
{
    private Dictionary<ItemType, int> items = new();

    public int GetQuantity(ItemType itemType)
    {
        return items[itemType];
    }

    public bool TryAdjustQuantity(ItemType itemType, int quantity)
    {
        if (!items.ContainsKey(itemType) && quantity > 0)
        {
            items[itemType] = quantity;
            return true;
        }
        int oldQuantity = items[itemType];
        int newQuantity = oldQuantity + quantity;
        if (newQuantity >= 0)
        {
            items[itemType] = newQuantity;
            return true;
        }

        return false;
    }
}