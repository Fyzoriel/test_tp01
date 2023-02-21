namespace FizzBuzz;

public class FizzBuzz
{
    public string GetFizzBuzz(int number)
    {
        if (number < 15)
        {
            throw new System.ArgumentException("Number must be greater than 15");
        }
        throw new System.NotImplementedException();
    }
}