namespace DesignPattern;

class Enemy
{
    private float _speed;
    public float Speed => _speed;
    public Enemy()
    {
        _speed = 0;
        GameManger.Instance.OnStartGame += StartRun;
    }

    private void StartRun()
    {
        _speed = 8f;
        Console.WriteLine("Enemy Starts Follow you");
    }
}

// Observer
// Strategy
