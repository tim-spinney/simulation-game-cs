namespace SimulationGame;

public class Person
{
    /* 1. What attributes describe a person?
     * 1.a. For each attribute, what are the possible values?
     * 1.b. What do we need to know about a person from the start of their existence?
     * 2. What does a person do?
     */
    private FullName name;
    private int hunger;
    private int energy;
    private Activity activity;
    private Residence? home;

    public Person(FullName name, Random rng)
    {
        this.name = name;
        hunger = rng.Next(MAX_ATTRIBUTE_VALUE);
        energy = rng.Next(MAX_ATTRIBUTE_VALUE);
    }

    public Activity GetActivity()
    {
        return activity;
    }

    public void AdvanceTime()
    {
        if (activity == Activity.Eating && home != null && home.TryTransferInventory(ItemType.Food, 1))
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
        else if (energy < 40)
        {
            activity = Activity.Sleeping;
        }
        else
        {
            activity = Activity.Idling;
        }
    }

    public void MoveIn(Residence residence)
    {
        home = residence;
    }

    public void MoveOut()
    {
        home = null;
    }

    private const int MAX_ATTRIBUTE_VALUE = 255;

    public override string ToString()
    {
        return $"Name: {name}, Hunger: {hunger}, Energy: {energy}, Activity: {activity}";
    }
}