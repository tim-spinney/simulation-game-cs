namespace SimulationGame;

public class FullName
{
    public readonly String firstName;
    public readonly String lastName;

    public FullName(String firstName, String lastName)
    {
        this.firstName = firstName;
        this.lastName = lastName;
    }

    public override string ToString()
    {
        return $"{firstName} {lastName}"; 
    } 
}