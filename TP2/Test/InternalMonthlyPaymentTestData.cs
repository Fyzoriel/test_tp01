using TP2;

namespace Test;

public class InternalMonthlyPaymentTestData
{
    public static IEnumerable<object[]> TestData
    {
        get
        {
            yield return new object[] { new LoanData(50000, 300), 0.03, false, false, false, false, false, 249.61 };
            yield return new object[] { new LoanData(50000, 300), 0.03, true, false, true, false, true, 266.28 };
        }
    }
}