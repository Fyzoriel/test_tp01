namespace TP2;

public class InsurancePayment : IInsurancePayment
{
    private readonly LoanAmount _loanAmount;
    private readonly LoanTermInMonths _loanTermInMonths;
    private double _interestRate;

    public InsurancePayment(LoanData loanData, bool isSporty, bool isSmoker, bool hasHeartCondition, bool isComputerEngineer, bool isFighterPilot)
    {
        _loanAmount = loanData.LoanAmount;
        _loanTermInMonths = loanData.LoanTermInMonths;
        CalculateInterestRate(isSporty, isSmoker, hasHeartCondition, isComputerEngineer, isFighterPilot);
    }
    
    private void CalculateInterestRate(bool isSporty, bool isSmoker, bool hasHeartCondition, bool isComputerEngineer, bool isFighterPilot)
    {
        _interestRate = 0.3;
        if (isSporty) _interestRate -= 0.05;
        if (isSmoker) _interestRate += 0.15;
        if (hasHeartCondition) _interestRate += 0.3;
        if (isComputerEngineer) _interestRate -= 0.05;
        if (isFighterPilot) _interestRate += 0.15;
    }
    
    public double CalculateMonthlyInsurancePayment()
    {
        var result = _loanAmount * _interestRate / 100 / 12;
        return Math.Round(result, 2);
    }
    
    public double CalculateTotalInsurancePayment()
    {
        return Math.Round(CalculateMonthlyInsurancePayment() * _loanTermInMonths, 2);
    }
}