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
    
    [Fact]
    public void ShouldReturn30percentIfLowerThan78570()
    {
        // Arrange 
        var taxes = new Taxes.Taxes();
        const int income = 30000;
        // Act
        var result = taxes.CalculateTax(income);
        
        // Assert
        Assert.Equal("30% - 9000", result);
    }
    
    [Fact]
    public void ShouldReturn41percentIfLowerThan168994()
    {
        // Arrange 
        var taxes = new Taxes.Taxes();
        const int income = 100000;
        // Act
        var result = taxes.CalculateTax(income);
        
        // Assert
        Assert.Equal("41% - 41000", result);
    }
    
    [Fact]
    public void ShouldReturn45percentIfHigherThan168994()
    {
        // Arrange 
        var taxes = new Taxes.Taxes();
        const int income = 200000;
        // Act
        var result = taxes.CalculateTax(income);
        
        // Assert
        Assert.Equal("45% - 90000", result);
    }
}