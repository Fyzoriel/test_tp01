using Tennis;

namespace TestTennis;

public class UnitTest1
{
    [Fact]
    [InlineData(0, 0, "Love - Love")]
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