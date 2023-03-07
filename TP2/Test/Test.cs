using TP2;

namespace Test;

public class UnitTest1
{
    [Theory]
    [InlineData(50000, 0.03, 300, 237.11)]
    [InlineData(100000, 0.03, 300, 474.21)]
    public void ItShouldReturnCorrectMonthlyPayment(int loanAmount, double interestRate, int loanTermInMonths, double expectedMonthlyPayment)
    {
        // Arrange
        var realEstateLoanCalculator = new RealEstateLoanCalculator(loanAmount, interestRate, loanTermInMonths);

        // Act
        var monthlyPayment = realEstateLoanCalculator.CalculateMonthlyPayment();
        
        // Assert
        Assert.Equal(expectedMonthlyPayment, monthlyPayment);
    }
}