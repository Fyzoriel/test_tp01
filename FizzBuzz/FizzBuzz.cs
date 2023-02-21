namespace FizzBuzz;

public class FizzBuzz
{
    public string GetFizzBuzz(int number)
    {
        ValidateNumber(number);
        
        throw new System.NotImplementedException();
    }
    
    private static void ValidateNumber(int number)
    {
        switch (number)
        {
            case < 15:
                throw new System.ArgumentException("Number must be greater than 15");
            case > 150:
                throw new System.ArgumentException("Number must be less than 150");
        }
    }
}