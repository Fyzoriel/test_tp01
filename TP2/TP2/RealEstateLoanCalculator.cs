namespace TP2;

public class RealEstateLoanCalculator
{
    private readonly LoanAmount _loanAmount;
    private readonly double _interestRate;
    private readonly LoanTermInMonths _loanTermInMonths;
    
    public RealEstateLoanCalculator(LoanData loanData, double interestRate)
    {
        _loanAmount = loanData.LoanAmount;
        _interestRate = interestRate;
        _loanTermInMonths = loanData.LoanTermInMonths;
    }
    
    public double CalculateMonthlyPayment()
    {
        double monthlyInterestRate = _interestRate / 12;
        return Math.Round((_loanAmount * monthlyInterestRate) / (1 - Math.Pow(1 + monthlyInterestRate, -_loanTermInMonths)), 2);
    }
    
    public double CalculateTotalInterest()
    {
        return Math.Round(CalculateMonthlyPayment() * _loanTermInMonths - _loanAmount, 2);
    }
}
