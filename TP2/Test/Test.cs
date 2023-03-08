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
        double monthlyPayment = realEstateLoanCalculator.CalculateMonthlyPayment();
        
        // Assert
        Assert.Equal(expectedMonthlyPayment, monthlyPayment);
    }

    [Theory]
    [InlineData(50000, false, false, false, false, false, 12.5)]
    [InlineData(50000, true, false, false, false, false, 10.42)]
    [InlineData(50000, false, true, false, false, false, 18.75)]
    public void ItShouldReturnCorrectMonthlyInsurancePayment(
        int loanAmount, bool isSporty, bool isSmoker, bool hasHeartCondition, 
        bool isComputerEngineer, bool isFighterPilot, double expected)
    {
        var monthlyInsurancePayment = new MonthlyInsurancePayment(loanAmount, isSporty, isSmoker, hasHeartCondition, isComputerEngineer, isFighterPilot);
        Assert.Equal(expected, monthlyInsurancePayment.CalculateMonthlyInsurancePayment());
    }
}