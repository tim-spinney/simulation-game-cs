using SimulationGame;

namespace TestProject1;

[TestClass]
public class PlaceOfBusinessTest
{
    [TestMethod("Does not allow any guests in if the closing time is before the opening time")]
    public void NeverAllowsGuestsIfClosesBeforeOpens()
    {
        // Arrange
        PlaceOfBusiness placeOfBusiness = new PlaceOfBusiness(new List<Person>(), 10, 5, 999, new Rectangle(0, 0, 1, 1));

        // Act
        placeOfBusiness.AdvanceTime(11);
        bool wasAllowedIn = placeOfBusiness.TryToLetPersonIn(new Person(new FullName("Test", "Subject"), new Random()));

        // Assert
        Assert.IsFalse(wasAllowedIn);
    }
}