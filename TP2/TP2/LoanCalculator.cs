namespace TP2;

public class LoanCalculator
{
    RealEstateLoanCalculator _realEstateLoanCalculator;
    InsurancePayment _insurancePayment;
    public LoanCalculator(RealEstateLoanCalculator realEstateLoanCalculator, InsurancePayment insurancePayment)
    {
        _realEstateLoanCalculator = realEstateLoanCalculator;
        _insurancePayment = insurancePayment;
    }

    public double CalculateMonthlyPayment()
    {
        return Math.Round(_realEstateLoanCalculator.CalculateMonthlyPayment() + _insurancePayment.CalculateMonthlyInsurancePayment(), 2);
    }
    
    public static double CalculateCapitalRepaidAfterTime(double monthlyPayment, int timeInMonths)
    {
        return Math.Round(monthlyPayment * timeInMonths, 2);
    }
}