namespace TestTaxes;

public class UnitTest1
{
    [Fact]
    public void ShouldThrowIfNegativeNumber()
    {
        // Arrange 
        var taxes = new Taxes.Taxes();
        // Act && Assert
        Assert.Throws<ArgumentException>(() => taxes.CalculateTax(-1));
    }
    
    [Fact]
    public void ShouldReturnZeroIfLowerThan10777()
    {
        // Arrange 
        var taxes = new Taxes.Taxes();
        const int income = 10750;
        // Act
        var result = taxes.CalculateTax(income);
        
        // Assert
        Assert.Equal("0% - 0", result);
    }
    
    [Fact]
    public void ShouldReturn11percentIfLowerThan27478()
    {
        // Arrange 
        var taxes = new Taxes.Taxes();
        const int income = 11000;
        // Act
        var result = taxes.CalculateTax(income);
        
        // Assert
        Assert.Equal("11% - 1210", result);
    }
}