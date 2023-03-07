using TP2;

namespace Test;

public class UnitTest1
{
    [Fact]
    public void ItShouldReturnCorrectMonthlyPayment()
    {
        // Arrange
        var realEstateLoanCalculator = new RealEstateLoanCalculator(50000, 0.03f, 25);

        // Act
        var monthlyPayment = realEstateLoanCalculator.CalculateMonthlyPayment();
        
        // Assert
        Assert.Equal(237.11f, monthlyPayment);
    }
}