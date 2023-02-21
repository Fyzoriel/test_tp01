namespace Taxes;

public class Taxes
{
    public decimal CalculateTax(int income)
    {
        if (income < 0)
        {
            throw new ArgumentException("Income cannot be negative", nameof(income));
        }
        throw new NotImplementedException();
    }
}