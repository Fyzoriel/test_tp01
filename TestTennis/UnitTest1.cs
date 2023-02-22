using Tennis;

namespace TestTennis;

public class UnitTest1
{
    [Theory]
    [InlineData(0, 0, "Love - Love")]
    
    [InlineData(1, 0, "Fifteen - Love")]
    [InlineData(0, 1, "Love - Fifteen")]
    [InlineData(1,1, "Fifteen - Fifteen")]
    
    [InlineData(2, 0, "Thirty - Love")]
    [InlineData(0, 2, "Love - Thirty")]
    [InlineData(2, 1, "Thirty - Fifteen")]
    [InlineData(1, 2, "Fifteen - Thirty")]
    [InlineData(2, 2, "Thirty - Thirty")]
    public void TestScore(int playerOneBall, int playerTwoBall, string expectedScore)
    {
        // Arrange
        var maxBalls = Math.Max(playerOneBall, playerTwoBall);
        var game = new Game();
        
        // Act
        for (var i = 0; i < maxBalls; i++)
        {
            if (i < playerOneBall)
            {
                game.PlayerOneScored();
            }
            
            if (i < playerTwoBall)
            {
                game.PlayerTwoScored();
            }
        }
        
        // Assert
        Assert.Equal(expectedScore, game.GetScore());
    }
}