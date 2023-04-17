namespace DesignPattern;

class Player
{
  
    private float _speed;
    public float Speed => _speed;

    private WeaponBase _weapon;
    public Player()
    {
        _speed = 0;
        GameManger.Instance.OnStartGame += StartRun;
        GameManger.Instance.OnPauseGame += SpeedDown;
        GameManger.Instance.OnResumeGame += SpeedUp;

    }

    public void ChangeWeapon(WeaponBase weapon)
    {
        _weapon = weapon;
    }

    public void Shoot()
    {
       _weapon.Attack();
    }
    private void SpeedUp()
    {
        _speed = 10;
    }

    private void SpeedDown()
    {
        _speed = 0f;
    }

    private void StartRun()
    {
        Console.WriteLine("Start Animation");
        _speed = 10f;
    }

   
}

public class Vandal : WeaponBase
{
    public override void Attack()
    {
        Console.WriteLine("Vandal shoot");
    }
}

public class Awp : WeaponBase
{
    public override void Attack()
    {
        Console.WriteLine("AWP Shoot");
    }
}

public class Knife : WeaponBase
{
    public override void Attack()
    {
        Console.WriteLine("Knife Cut");
    }
}
public abstract class WeaponBase
{
    public abstract void Attack();
}

// Observer
// Strategy
