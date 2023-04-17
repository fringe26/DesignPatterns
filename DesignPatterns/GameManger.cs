namespace DesignPattern;

// Singletone
public class GameManger
{
    private static GameManger _instance = null;
    public int Level { get; private set; }

    public event Action OnStartGame;
    public event Action OnEndGame;
    public event Action OnPauseGame;
    public event Action OnResumeGame;


    public static GameManger Instance
    {
        get
        {
            if( _instance == null)
            {
                _instance = new GameManger();
            }
            return _instance;
        }
    }

    public void StartGame()
    {
        Level = 1;
        Console.WriteLine("Game Starting...");
        Thread.Sleep(3000);

        OnStartGame?.Invoke();
    }

    public void IncreaseLevel()
    {
        Level++;
    }
}


// Observer
// Strategy
