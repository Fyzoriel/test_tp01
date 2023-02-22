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
        if (_playerOneBalls >= 3 && _playerTwoBalls >= 3 && _playerOneBalls - _playerTwoBalls == 1)
        {
            return "Advantage Player One";
        }
        if (_playerOneBalls >= 3 && _playerTwoBalls >= 3 && _playerTwoBalls - _playerOneBalls == 1)
        {
            return "Advantage Player Two";
        }
        
        return $"{GetPlayerScore(_playerOneBalls)} - {GetPlayerScore(_playerTwoBalls)}";;
    }
    
    private string GetPlayerScore(int playerBalls)
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
        return _playerOneBalls == _playerTwoBalls && _playerOneBalls >= 3;
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