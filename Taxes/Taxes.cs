namespace Taxes;

public class Taxes
{
    public string CalculateTax(int income)
    {
        ValidateIncome(income);
        if (income <= 10777)
        {
            return "0% - 0";
        }
        
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