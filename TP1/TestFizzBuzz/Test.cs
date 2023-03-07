namespace TestFizzBuzz;

public class UnitTest1
{
    [Fact]
    public void FizzBuzz()
    {
        // Arrange
        var fizzBuzz = new FizzBuzz.FizzBuzz();
        const int number = 15;
        
        // Act
        var result = fizzBuzz.GetFizzBuzz(number);
        
        // Assert
        const string expected = "1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz";
        Assert.Equal(expected, result);
    }
    
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