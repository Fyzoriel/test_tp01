namespace TP2;

public class MonthlyInsurancePayment
{
    private readonly LoanAmount _loanAmount;
    private readonly double _interestRate;

    public MonthlyInsurancePayment(LoanAmount loanAmount, bool isSporty, bool isSmoker, bool hasHeartCondition, bool isComputerEngineer, bool isFighterPilot)
    {
        _loanAmount = loanAmount;
        _interestRate = 0.3;
        if (isSporty) _interestRate -= 0.05;
    }
    
    public double CalculateMonthlyInsurancePayment()
    {
        var result = _loanAmount * _interestRate / 100 / 12;
        return Math.Round(result, 2);
    }
}