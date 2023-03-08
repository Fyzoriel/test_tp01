using TP2;

namespace Test;

public class UnitTest1
{
    [Theory]
    [InlineData(50000, 0.03, 300, 237.11)]
    [InlineData(100000, 0.03, 300, 474.21)]
    public void ItShouldReturnCorrectRealEstateMonthlyPayment(int loanAmount, double interestRate, int loanTermInMonths,
        double expectedMonthlyPayment)
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
    [InlineData(50000, false, false, true, false, false, 25)]
    [InlineData(50000, false, false, false, true, false, 10.42)]
    [InlineData(50000, false, false, false, false, true, 18.75)]
    [InlineData(50000, true, true, true, true, true, 33.33)]
    public void ItShouldReturnCorrectMonthlyInsurancePayment(
        int loanAmount, bool isSporty, bool isSmoker, bool hasHeartCondition,
        bool isComputerEngineer, bool isFighterPilot, double expected)
    {
        var monthlyInsurancePayment = new MonthlyInsurancePayment(loanAmount, isSporty, isSmoker, hasHeartCondition,
            isComputerEngineer, isFighterPilot);
        Assert.Equal(expected, monthlyInsurancePayment.CalculateMonthlyInsurancePayment());
    }
    
    [Theory]
    [InlineData(50000, 0.03, 300, false, false, false, false, false, 249.61)]
    [InlineData(50000, 0.03, 300, true, false, true, false, true, 266.28)]
    public void ItShouldReturnCorrectMonthlyPayment(
        int loanAmount, double interestRate, int loanTermInMonths,
        bool isSporty, bool isSmoker, bool hasHeartCondition,
        bool isComputerEngineer, bool isFighterPilot, double expected)
    {
        // Arrange
        var realEstateLoanCalculator = new RealEstateLoanCalculator(loanAmount, interestRate, loanTermInMonths);
        var monthlyInsurancePayment = new MonthlyInsurancePayment(loanAmount, isSporty, isSmoker, hasHeartCondition,
            isComputerEngineer, isFighterPilot);
        var loanCalculator = new LoanCalculator(realEstateLoanCalculator, monthlyInsurancePayment);

        // Act
        double monthlyPayment = loanCalculator.CalculateMonthlyPayment();
        
        // Assert
        Assert.Equal(expected, monthlyPayment);
    }

    [Theory]
    [InlineData(50000, 0.03, 300, 21133)]
    public void ItShouldReturnCorrectTotalLoanInterest(int loanAmount, double interestRate, int loanTermInMonths,
        double expected)
    {
        // Arrange
        var realEstateLoanCalculator = new RealEstateLoanCalculator(loanAmount, interestRate, loanTermInMonths);
        
        // Act
        var totalLoanInterest = realEstateLoanCalculator.CalculateTotalInterest();
        
        // Assert
        Assert.Equal(expected, totalLoanInterest);
    }
}