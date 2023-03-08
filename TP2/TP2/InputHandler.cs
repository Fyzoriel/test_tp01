namespace TP2;

public class InputHandler
{
    private static T GetValidInput<T>(string prompt, Func<string, bool> validateFunc, Func<string, T> convertFunc)
    {
        while (true)
        {
            Console.Write(prompt);
            var input = Console.ReadLine();
            if (input != null && validateFunc(input))
            {
                return convertFunc(input);
            }
            Console.WriteLine("Invalid input. Please try again.");
        }
    }
    
    public static bool GetBoolInput(string prompt)
    {
        return GetValidInput(prompt, input => input == "y" || input == "n", input => input == "y");
    }
    
    public static double GetDoubleInput(string prompt)
    {
        return GetValidInput(prompt, input => double.TryParse(input, out _), double.Parse);
    }

    public static LoanAmount GetLoanAmountInput(string prompt)
    {
        return GetValidInput(
            prompt,
            input =>
            {
                if (!int.TryParse(input, out int amount))
                {
                    return false;
                }

                try
                {
                    _ = new LoanAmount(amount);
                    return true;
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                    return false;
                }
            },
            int.Parse);
    }
    
    public static LoanTermInMonths GetLoanTermInMonthsInput(string prompt)
    {
        return GetValidInput(
            prompt,
            input =>
            {
                if (!int.TryParse(input, out int amount))
                {
                    return false;
                }

                try
                {
                    _ = new LoanTermInMonths(amount);
                    return true;
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                    return false;
                }
            },
            int.Parse);
    }
}