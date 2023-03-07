namespace TP2;

public class LoanTermInMonths
{
    private int _term { get; }
    public LoanTermInMonths(int loanTermInMonths)
    {
        if (loanTermInMonths < 108)
        {
            throw new ArgumentOutOfRangeException(nameof(loanTermInMonths), "Loan term must be at least 108 months");
        }

        if (loanTermInMonths > 300)
        {
            throw new ArgumentOutOfRangeException(nameof(loanTermInMonths), "Loan term must be at most 300 months");
        }
        _term = loanTermInMonths;
    }
    
    public static implicit operator LoanTermInMonths(int loanTermInMonths)
    {
        return new LoanTermInMonths(loanTermInMonths);
    }
    
    public static implicit operator int(LoanTermInMonths loanTermInMonths)
    {
        return loanTermInMonths._term;
    }
}
