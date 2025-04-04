namespace SimulationGame;

public class Person
{
    /* 1. What attributes describe a person?
     * 1.a. For each attribute, what are the possible values?
     * 1.b. What do we need to know about a person from the start of their existence?
     * 2. What does a person do?
     */
    private string firstName;
    private string lastName;
    private int hunger;
    private int energy;
    private uint age;

    public Person(string name)
    {
        string[] nameParts = name.Split(" ");
        firstName = nameParts[0];
        lastName = nameParts[1];
    }

    public void AdvanceTime()
    {
        hunger++;
        energy--;
    }

    public string GetName()
    {
        return firstName + " " + lastName;
    }

    public void GetMarried(String adoptedLastName)
    {
        lastName = adoptedLastName;
    }
}