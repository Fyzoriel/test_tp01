namespace TestFizzBuzz;

public class UnitTest1
{
    [Fact]
    public void LessThan15()
    {
        // Arrange
        var fizzBuzz = new FizzBuzz.FizzBuzz();

        // Act & Assert
        Assert.Throws<ArgumentException>(() => fizzBuzz.GetFizzBuzz(0));
    }
}