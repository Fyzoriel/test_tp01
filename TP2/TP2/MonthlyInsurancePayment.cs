namespace TP2;

public class MonthlyInsurancePayment
{
    private readonly LoanAmount _loanAmount;
    private readonly bool _isSporty;
    private readonly bool _isSmoker;
    private readonly bool _hasHeartCondition;
    private readonly bool _isComputerEngineer;
    private readonly bool _isFighterPilot;

    public MonthlyInsurancePayment(LoanAmount loanAmount, bool isSporty, bool isSmoker, bool hasHeartCondition, bool isComputerEngineer, bool isFighterPilot)
    {
        _loanAmount = loanAmount;
        _isSporty = isSporty;
        _isSmoker = isSmoker;
        _hasHeartCondition = hasHeartCondition;
        _isComputerEngineer = isComputerEngineer;
        _isFighterPilot = isFighterPilot;
    }
    
    public double CalculateMonthlyInsurancePayment()
    {
        return 125;
    }
}