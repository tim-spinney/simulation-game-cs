namespace SimulationGame;

public class Simulator
{
    private List<Person> persons;
    private List<PlaceOfBusiness> businesses = new List<PlaceOfBusiness>();
    private uint currentTime;

    public Simulator()
    {
        persons = new List<Person>();
        
        persons.Add(new Person("Hugh", "Mann"));
        persons.Add(new Person("Jane", "Doe"));
        persons.Add(new Person("Another", "person"));
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
    }
}