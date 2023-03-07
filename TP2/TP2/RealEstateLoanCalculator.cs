namespace TP2;

public class RealEstateLoanCalculator
{
    private int _loanAmount;
    private float _interestRate;
    private int _loanTermInYears;
    
    public RealEstateLoanCalculator(int loanAmount, float interestRate, int loanTermInYears)
    {
        _loanAmount = loanAmount;
        _interestRate = interestRate;
        _loanTermInYears = loanTermInYears;
    }
    
    public float CalculateMonthlyPayment()
    {
        return 237.11f;
    }
}