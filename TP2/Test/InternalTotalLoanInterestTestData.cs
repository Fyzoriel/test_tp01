using TP2;

namespace Test;

public class InternalTotalLoanInterestTestData
{
    public static IEnumerable<object[]> TestData
    {
        get
        {
            yield return new object[] { new LoanData(50000, 300), 3, 21133 };
        }
    }
}