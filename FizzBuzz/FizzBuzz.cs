using System.Text;

namespace FizzBuzz;

public class FizzBuzz
{
    public string GetFizzBuzz(int number)
    {
        ValidateNumber(number);
        
        StringBuilder result = new();
        for (var i = 1; i <= number; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                result.Append("FizzBuzz ");
            }
            else if (i % 3 == 0)
            {
                result.Append("Fizz ");
            }
            else if (i % 5 == 0)
            {
                result.Append("Buzz ");
            }
            else
            {
                result.Append(i).Append(' ');
            }
        }
        
        return result.ToString().Trim();
    }
    
    private static void ValidateNumber(int number)
    {
        switch (number)
        {
            case < 15:
                throw new ArgumentException("Number must be greater than 15");
            case > 150:
                throw new ArgumentException("Number must be less than 150");
        }
    }
}