namespace Taxes;

public class Taxes
{
    public string CalculateTax(int income)
    {
        ValidateIncome(income);
        throw new NotImplementedException();
    }
    
    private void ValidateIncome(int income)
    {
        if (income < 0)
        {
            throw new ArgumentException("Income cannot be negative");
        }
    }
}