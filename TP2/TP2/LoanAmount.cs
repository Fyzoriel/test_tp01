namespace TP2;

public class LoanAmount
{
    private int _amount { get; }
    
    public LoanAmount(int amount)
    {
        if (amount < 50000) {
            throw new ArgumentOutOfRangeException(nameof(amount), "Loan amount must be at least 50,000");
        }
        _amount = amount;
    }
    
    public static implicit operator LoanAmount(int amount)
    {
        return new LoanAmount(amount);
    }
    
    public static implicit operator int(LoanAmount loanAmount)
    {
        return loanAmount._amount;
    }
}
