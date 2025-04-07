namespace SimulationGame;

public class Room
{
    private readonly List<Person> employees;
    private readonly uint opensAt;
    private readonly uint closesAt;
    private readonly uint maxCapacity;
    private uint currentNumGuests;
    private bool isOpen;

    /* Preconditions:
     * - opensAt must be greater than closesAt or nobody will ever be allowed in
     * - opensAt and closesAt must be less than 1440 or nobody will ever be allowed in
     */
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
        isOpen = (currentTime % MINUTES_PER_DAY) >= opensAt && 
                 (currentTime % MINUTES_PER_DAY) <= closesAt;
    }

    private const uint MINUTES_PER_DAY = 60 * 24;
}