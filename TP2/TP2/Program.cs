using TP2;

var loanAmount = InputHandler.GetLoanAmountInput("Enter loan amount: ");
var loanTermInMonths = InputHandler.GetLoanTermInMonthsInput("Enter loan term in months: ");
var interestRate = InputHandler.GetDoubleInput("Enter interest rate: ");

var isSporty = InputHandler.GetBoolInput("Are you sporty? (y/n): ");
var isSmoker = InputHandler.GetBoolInput("Are you a smoker? (y/n): ");
var hasHeartCondition = InputHandler.GetBoolInput("Do you have a heart condition? (y/n): ");
var isComputerEngineer = InputHandler.GetBoolInput("Are you a computer engineer? (y/n): ");
var isFighterPilot = InputHandler.GetBoolInput("Are you a fighter pilot? (y/n): ");

Console.WriteLine(interestRate);

var loanData = new LoanData(loanAmount, loanTermInMonths);
var realEstateLoanCalculator = new RealEstateLoanCalculator(loanData, interestRate);

var insurancePayment = new InsurancePayment(loanData, isSporty, isSmoker, hasHeartCondition,
    isComputerEngineer, isFighterPilot);

var loanCalculator = new LoanCalculator(realEstateLoanCalculator, insurancePayment);

var monthlyPayment = loanCalculator.CalculateMonthlyPayment();
var monthlyInsurancePayment = insurancePayment.CalculateMonthlyInsurancePayment();
var totalLoanInterest = realEstateLoanCalculator.CalculateTotalInterest();
var totalInsurancePayment = insurancePayment.CalculateTotalInsurancePayment();

Console.WriteLine($"Monthly payment: {monthlyPayment}");
Console.WriteLine($"Monthly insurance payment: {monthlyInsurancePayment}");
Console.WriteLine($"Total monthly payment: {monthlyPayment + monthlyInsurancePayment}");

Console.WriteLine($"Total loan interest: {totalLoanInterest}");
Console.WriteLine($"Total insurance payment: {totalInsurancePayment}");
Console.WriteLine($"Total loan interest + total insurance payment: {totalLoanInterest + totalInsurancePayment}");

Console.WriteLine("Press any key to exit...");
Console.ReadKey();
