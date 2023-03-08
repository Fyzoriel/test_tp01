using TP2;

namespace Test;

public class InternalRealEstateLoanMonthlyPaymentTestData
{
    public static IEnumerable<object[]> TestData
    {
        get
        {
            yield return new object[] {new LoanData(50000, 300), 3, 237.11};
            yield return new object[] {new LoanData(100000, 300), 3, 474.21};
        }
    }
}