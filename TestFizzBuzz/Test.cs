namespace TestFizzBuzz;

public class UnitTest1
{
    [Fact]
    public void LessThan15()
    {
        // Arrange
        var fizzBuzz = new FizzBuzz.FizzBuzz();
        const int number = 14;
        
        // Act & Assert
        Assert.Throws<ArgumentException>(() => fizzBuzz.GetFizzBuzz(number));
    }
    
    [Fact]
    public void GreaterThan150()
    {
        // Arrange
        var fizzBuzz = new FizzBuzz.FizzBuzz();
        const int number = 151;
        
        // Act & Assert
        Assert.Throws<ArgumentException>(() => fizzBuzz.GetFizzBuzz(number));
    }
}