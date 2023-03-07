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
        if (income <= 27478)
        {
            return $"11% - {income * 0.11}";
        }
        if (income <= 78570)
        {
            return $"30% - {income * 0.3}";
        }
        if (income <= 168994)
        {
            return $"41% - {income * 0.41}";
        }
        
        return $"45% - {income * 0.45}";
    }
    
    private void ValidateIncome(int income)
    {
        if (income < 0)
        {
            throw new ArgumentException("Income cannot be negative");
        }
    }
}