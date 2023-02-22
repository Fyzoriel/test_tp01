namespace Tennis;

public class Game
{
    private int _playerOneBalls, _playerTwoBalls;
    
    public string GetScore()
    {
        if (IsDeuce())
        {
            return "Deuce";
        }
        if (IsAdvantage())
        {
            return $"Advantage {GetPlayerWithHighestBalls()}";
        }

        return $"{GetPlayerScore(_playerOneBalls)} - {GetPlayerScore(_playerTwoBalls)}";;
    }
    
    private static string GetPlayerScore(int playerBalls)
    {
        return playerBalls switch
        {
            0 => "Love",
            1 => "Fifteen",
            2 => "Thirty",
            _ => "Forty",
        };
    }
    
    private bool IsDeuce()
    {
        return AreScoreEqual() && BothPlayersHasAtLeastForty();
    }
    private bool IsAdvantage()
    {
        return BothPlayersHasAtLeastForty() && IsOneBallDifference();
    }
    
    private bool IsOneBallDifference()
    {
        return Math.Abs(_playerOneBalls - _playerTwoBalls) == 1;
    }
    
    private bool AreScoreEqual()
    {
        return _playerOneBalls == _playerTwoBalls;
    }
    
    private string GetPlayerWithHighestBalls()
    {
        return _playerOneBalls > _playerTwoBalls ? "Player One" : "Player Two";
    }
    
    private bool BothPlayersHasAtLeastForty()
    {
        return _playerOneBalls >= 3 && _playerTwoBalls >= 3;
    }
    
    public void PlayerOneScored()
    {
        _playerOneBalls++;
    }
    public void PlayerTwoScored()
    {
        _playerTwoBalls++;
    }
}