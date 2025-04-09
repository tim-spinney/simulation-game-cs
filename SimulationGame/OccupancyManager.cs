namespace SimulationGame;

public class OccupancyManager
{
    private HashSet<Person> occupants = new HashSet<Person>();
    private readonly uint maxCapacity;

    public OccupancyManager(uint maxCapacity)
    {
        this.maxCapacity = maxCapacity;
    }

    public bool TryAdmitPerson(Person person)
    {
        if (occupants.Count < this.maxCapacity)
        {
            occupants.Add(person);
            return true;
        }
        return false;
    }

    public void PersonLeft(Person person)
    {
        occupants.Remove(person);
    }
}