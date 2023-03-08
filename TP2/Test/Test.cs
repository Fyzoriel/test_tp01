using TP2;

namespace Test;

public class UnitTest1
{
    [Theory]
    [MemberData(nameof(InternalRealEstateLoanMonthlyPaymentTestData.TestData), MemberType = typeof(InternalRealEstateLoanMonthlyPaymentTestData))]
    public void ItShouldReturnCorrectRealEstateMonthlyPayment(LoanData loanData, double interestRate, double expectedMonthlyPayment)
    {
        // Arrange
        var realEstateLoanCalculator = new RealEstateLoanCalculator(loanData, interestRate);

        // Act
        double monthlyPayment = realEstateLoanCalculator.CalculateMonthlyPayment();
        
        // Assert
        Assert.Equal(expectedMonthlyPayment, monthlyPayment);
    }

    [Theory]
    [MemberData(nameof(InternalInsuranceMonthlyPaymentTestData.TestData), MemberType = typeof(InternalInsuranceMonthlyPaymentTestData))]
    public void ItShouldReturnCorrectMonthlyInsurancePayment(
        LoanData loanData, bool isSporty, bool isSmoker, bool hasHeartCondition,
        bool isComputerEngineer, bool isFighterPilot, double expected)
    {
        var monthlyInsurancePayment = new InsurancePayment(loanData, isSporty, isSmoker, hasHeartCondition,
            isComputerEngineer, isFighterPilot);
        Assert.Equal(expected, monthlyInsurancePayment.CalculateMonthlyInsurancePayment());
    }
    
    [Theory]
    [MemberData(nameof(InternalMonthlyPaymentTestData.TestData), MemberType = typeof(InternalMonthlyPaymentTestData))]
    public void ItShouldReturnCorrectMonthlyPayment(
        LoanData loanData, double interestRate,
        bool isSporty, bool isSmoker, bool hasHeartCondition,
        bool isComputerEngineer, bool isFighterPilot, double expected)
    {
        // Arrange
        var realEstateLoanCalculator = new RealEstateLoanCalculator(loanData, interestRate);
        var monthlyInsurancePayment = new InsurancePayment(loanData, isSporty, isSmoker, hasHeartCondition,
            isComputerEngineer, isFighterPilot);
        var loanCalculator = new LoanCalculator(realEstateLoanCalculator, monthlyInsurancePayment);

        // Act
        double monthlyPayment = loanCalculator.CalculateMonthlyPayment();
        
        // Assert
        Assert.Equal(expected, monthlyPayment);
    }

    [Theory]
    [MemberData(nameof(InternalTotalLoanInterestTestData.TestData), MemberType = typeof(InternalTotalLoanInterestTestData))]
    public void ItShouldReturnCorrectTotalLoanInterest(LoanData loanData, double interestRate, double expected)
    {
        // Arrange
        var realEstateLoanCalculator = new RealEstateLoanCalculator(loanData, interestRate);
        
        // Act
        var totalLoanInterest = realEstateLoanCalculator.CalculateTotalInterest();
        
        // Assert
        Assert.Equal(expected, totalLoanInterest);
    }

    [Theory]
    [MemberData(nameof(InternalTotalInsuranceInterestTestData.TestData), MemberType = typeof(InternalTotalInsuranceInterestTestData))]
    public void ItShouldReturnCorrectTotalInsuranceInterest(
        LoanData loanData, bool isSporty, bool isSmoker, bool hasHeartCondition,
        bool isComputerEngineer, bool isFighterPilot, double expected)
    {
        // Arrange
        var monthlyInsurancePayment = new InsurancePayment(loanData, isSporty, isSmoker, hasHeartCondition,
            isComputerEngineer, isFighterPilot);
        
        // Act
        var totalInsuranceInterest = monthlyInsurancePayment.CalculateTotalInsurancePayment();
        
        // Assert
        Assert.Equal(expected, totalInsuranceInterest);
    }
}