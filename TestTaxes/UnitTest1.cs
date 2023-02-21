namespace TestTaxes;

public class UnitTest1
{
    [Fact]
    public void ShouldThrowIfNegativeNumber()
    {
        // Arrange 
        var taxes = new Taxes.Taxes();
        // Act && Assert
        Assert.Throws<ArgumentOutOfRangeException>(() => taxes.CalculateTax(-1));
    }
}