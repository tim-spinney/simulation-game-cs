namespace SimulationGame;

public class Simulator
{
    private List<Person> persons = new();
    private List<Residence> residences = new();
    private List<PlaceOfBusiness> businesses = new();
    private uint currentTime;

    public Simulator(uint population, uint numHomes, NameGenerator nameGenerator, Random rng)
    {
        for (uint i = 0; i < population; i++)
        {
            persons.Add(new Person(nameGenerator.GenerateName(), rng));
        }

        int numUnhousedPersons = persons.Count;
        for (int i = 0; i < numHomes; i++)
        {
            int maxCapacity = rng.Next(4);
            Residence residence = new Residence((uint)maxCapacity, new Rectangle(0, 0, 50, 1)); 
            residences.Add(residence);
            for (int j = 0; j < maxCapacity && numUnhousedPersons > 0; j++)
            {
                Person person = persons[numUnhousedPersons-1];
                residence.MovePersonIn(person);
                person.MoveIn(residence);
                numUnhousedPersons--;
            }
        }
        // TODO: add businesses
    }
    
    public void SimulateForever()
    {
        while (true)
        {
            advanceOneTimeStep();
        }
    }

    public void AdvanceTime(uint numTimeSteps)
    {
        uint endTime = currentTime + numTimeSteps;
        while (currentTime < endTime)
        {
            advanceOneTimeStep();
        }
    }

    private void advanceOneTimeStep()
    {
        currentTime++;
        foreach (Person person in persons)
        {
            person.AdvanceTime();
        }
        foreach (PlaceOfBusiness room in businesses)
        {
            room.AdvanceTime(currentTime);
        }
        Console.WriteLine($"Time {currentTime}");
        persons.ForEach(Console.WriteLine);
    }
}