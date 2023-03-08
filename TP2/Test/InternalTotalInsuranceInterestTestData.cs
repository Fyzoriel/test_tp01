using TP2;

namespace Test;

public class InternalTotalInsuranceInterestTestData
{
    public static IEnumerable<object[]> TestData
    {
        get
        {
            yield return new object[] { new LoanData(50000, 300), false, false, false, false, false, 3750 };
        }
    }
}