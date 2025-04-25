namespace TestProject1;

using SimulationGame;

[TestClass]
public class PersonTest
{
    [TestMethod("Person starts out idling by default")]
    public void StartsIdle()
    {
        // Arrange
        Person person = new Person(new FullName("Test", "Subject"), new Random());

        // Assert
        Assert.AreEqual(Activity.Idling, person.GetActivity());
    }

    [TestMethod("Person switches to eating when hungry")]
    public void EatsWhenHungry()
    {
        // Arrange - create person who is not quite hungry
        
        // Act - advance time for a certain time period
        
        // Assert - person is eating
    }

    [TestMethod("Person switches to sleeping when low on energy")]
    public void SleepsWhenLowOnEnergy()
    {
        
    }

    [TestMethod("Person stops eating when no longer hungry")]
    public void StopsEatingWhenNoLongerHungry()
    {
        // Arrange - create person who is hungry
        
        // Act - advance time for a certain time period
        
        // Assert - person is not eating
        
    }

    [TestMethod("Person stops sleeping when no longer tired")]
    public void StopsSleepingWhenNoLongerTired()
    {
        
    }

    [TestMethod("Person prioritizes sleeping over eating")]
    public void PrioritizesSleepingOverEating()
    {
        
    }
}