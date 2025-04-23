using SimulationGame;

namespace TestProject1;

[TestClass]
public class ScheduleManagerTest
{
    [TestMethod]
    public void StartsClosed()
    {
        ScheduleManager manager = new(0, 4);
        
        Assert.IsFalse(manager.IsOpen());
    }

    public void BecomesOpenAfterOpeningTime()
    {
        // Arrange
        ScheduleManager manager = new(1, 4);
        
        // Act
        manager.AdvanceTime(2);
        
        // Assert
        Assert.IsTrue(manager.IsOpen());
    }

    public void BecomesClosedAfterClosingTime()
    {
        // Arrange
        ScheduleManager manager = new(55, 66);
        manager.AdvanceTime(66);
        Assert.IsTrue(manager.IsOpen()); // not main assertion, just a sanity check
        
        // Act
        manager.AdvanceTime(67);
        
        // Assert
        Assert.IsFalse(manager.IsOpen());
    }
}