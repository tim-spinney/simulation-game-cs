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
    private Activity activity;

    public Person(string firstName, string lastName)
    {
        this.firstName = firstName;
        this.lastName = lastName;
    }

    public Activity GetActivity()
    {
        return activity;
    }

    public void AdvanceTime()
    {
        if (activity == Activity.Eating)
        {
            hunger -= 5;
        }
        else
        {
            hunger++;
        }

        if (activity == Activity.Sleeping)
        {
            energy += 5;
        }
        else
        {
            energy--;
        }

        if (hunger > 40)
        {
            activity = Activity.Eating;
        }

        if (energy < 40)
        {
            activity = Activity.Sleeping;
        }
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