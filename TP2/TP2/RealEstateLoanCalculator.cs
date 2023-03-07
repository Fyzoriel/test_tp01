namespace TP2;

public class RealEstateLoanCalculator
{
    private readonly int _loanAmount;
    private readonly double _interestRate;
    private readonly int _loanTermInMonths;
    
    public RealEstateLoanCalculator(int loanAmount, double interestRate, int loanTermInMonths)
    {
        _loanAmount = loanAmount;
        _interestRate = interestRate;
        _loanTermInMonths = loanTermInMonths;
    }
    
    public double CalculateMonthlyPayment()
    {
        double monthlyInterestRate = _interestRate / 12;
        return Math.Round((_loanAmount * monthlyInterestRate) / (1 - Math.Pow(1 + monthlyInterestRate, -_loanTermInMonths)), 2);
    }
}