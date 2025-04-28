namespace SimulationGame;

public class PlaceOfBusiness : Location
{
    private readonly List<Person> employees;
    private readonly ScheduleManager scheduleManager;
    private readonly OccupancyManager occupancyManager;
    private uint visitorsToday;

    /* Preconditions:
     * - opensAt must be greater than closesAt or nobody will ever be allowed in
     * - opensAt and closesAt must be less than 1440 or nobody will ever be allowed in
     */
    public PlaceOfBusiness(List<Person> employees, uint opensAt, uint closesAt, uint maxCapacity, Rectangle bounds)
    : base(bounds) {
        this.employees = employees;
        scheduleManager = new ScheduleManager(opensAt, closesAt);
        occupancyManager = new OccupancyManager(maxCapacity);
    }

    public void Hire(Person person)
    {
        employees.Add(person);
    }

    public void Fire(Person person)
    {
        employees.Remove(person);
    }

    /// <summary>
    /// Checks whether the given person is currently allowed in. If they are,
    /// counts them as one of the visitors to this Room.
    /// </summary>
    /// <param name="person"></param>
    /// <returns>Whether the person was admitted into the Room.</returns>
    public bool TryToLetPersonIn(Person person)
    {
        if (employees.Contains(person))
        {
            return true;
        }
        if (scheduleManager.IsOpen())
        {
            return occupancyManager.TryAdmitPerson(person);
        }

        return false;
    }

    public void PersonLeft(Person person)
    {
        occupancyManager.PersonLeft(person);
        visitorsToday++;
    }

    public void AdvanceTime(uint currentTime)
    {
        scheduleManager.AdvanceTime(currentTime);
        if (currentTime % ScheduleManager.MINUTES_PER_DAY == 0)
        {
            visitorsToday = 0;
        }
    }
}