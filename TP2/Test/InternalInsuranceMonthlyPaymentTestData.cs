using TP2;

namespace Test;

public class InternalInsuranceMonthlyPaymentTestData
{
    public static IEnumerable<object[]> TestData
    {
        get
        {
            yield return new object[] { new LoanData(50000, 300), false, false, false, false, false, 12.5 };
            yield return new object[] { new LoanData(50000, 300), true, false, false, false, false, 10.42 };
            yield return new object[] { new LoanData(50000, 300), false, true, false, false, false, 18.75 };
            yield return new object[] { new LoanData(50000, 300), false, false, true, false, false, 25 };
            yield return new object[] { new LoanData(50000, 300), false, false, false, true, false, 10.42 };
            yield return new object[] { new LoanData(50000, 300), false, false, false, false, true, 18.75 };
            yield return new object[] { new LoanData(50000, 300), true, true, true, true, true, 33.33 };
        }
    }
}