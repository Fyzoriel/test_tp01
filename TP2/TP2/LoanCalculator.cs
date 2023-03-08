﻿namespace TP2;

public class LoanCalculator
{
    RealEstateLoanCalculator _realEstateLoanCalculator;
    MonthlyInsurancePayment _monthlyInsurancePayment;
    public LoanCalculator(RealEstateLoanCalculator realEstateLoanCalculator, MonthlyInsurancePayment monthlyInsurancePayment)
    {
        _realEstateLoanCalculator = realEstateLoanCalculator;
        _monthlyInsurancePayment = monthlyInsurancePayment;
    }

    public double CalculateMonthlyPayment()
    {
        return Math.Round(_realEstateLoanCalculator.CalculateMonthlyPayment() + _monthlyInsurancePayment.CalculateMonthlyInsurancePayment(), 2);
    }
}