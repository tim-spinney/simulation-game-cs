namespace SimulationGame;

public class Room
{
    private readonly List<Person> employees;
    private readonly uint opensAt;
    private readonly uint closesAt;
    private readonly uint maxCapacity;
    private uint currentNumGuests;
    private bool isOpen;

    public Room(List<Person> employees, uint opensAt, uint closesAt, uint maxCapacity)
    {
        this.employees = employees;
        this.opensAt = opensAt;
        this.closesAt = closesAt;
        this.maxCapacity = maxCapacity;
    }

    public void Hire(Person person)
    {
        employees.Add(person);
    }

    public void Fire(Person person)
    {
        employees.Remove(person);
    }

    public bool TryToLetPersonIn(Person person)
    {
        if (employees.Contains(person))
        {
            return true;
        }
        if (isOpen && currentNumGuests < maxCapacity)
        {
            currentNumGuests++;
            return true;
        }

        return false;
    }

    public void PersonLeft()
    {
        if (currentNumGuests > 0)
        {
            currentNumGuests--;
        }
    }

    public void AdvanceTime(uint currentTime)
    {
        isOpen = (currentTime % 1440) >= opensAt && 
                 (currentTime % 1440) <= closesAt;
    }
}