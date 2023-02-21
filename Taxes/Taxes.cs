namespace Taxes;

public class Taxes
{
    public decimal CalculateTax(int income)
    {
        ValidateIncome(income);
        throw new NotImplementedException();
    }
    
    public void ValidateIncome(int income)
    {
        if (income < 0)
        {
            throw new ArgumentException("Income cannot be negative");
        }
    }
}