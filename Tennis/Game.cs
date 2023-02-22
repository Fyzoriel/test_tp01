namespace Tennis;

public class Game
{
    private int _playerOneBalls, _playerTwoBalls;
    
    public string GetScore()
    {
        return $"{GetPlayerScore(_playerOneBalls)} - {GetPlayerScore(_playerTwoBalls)}";;
    }
    
    private string GetPlayerScore(int playerBalls)
    {
        if (playerBalls == 0)
        {
            return "Love";
        }

        throw new NotImplementedException();
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