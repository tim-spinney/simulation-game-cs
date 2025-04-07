using SimulationGame;

namespace TestProject1;

[TestClass]
public class RoomTest
{
    [TestMethod("Does not allow any guests in if the closing time is before the opening time")]
    public void NeverAllowsGuestsIfClosesBeforeOpens()
    {
        // Arrange
        Room room = new Room(new List<Person>(), 10, 5, 999);

        // Act
        room.AdvanceTime(11);
        bool wasAllowedIn = room.TryToLetPersonIn(new Person("test", "test"));

        // Assert
        Assert.IsFalse(wasAllowedIn);
    }
}