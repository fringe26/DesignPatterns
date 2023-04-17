namespace DesignPattern;

public class Program
{
  
    static void Main(string[] args)
    {
        #region Singletone
        //GameManger.Instance.StartGame();
        //GameManger.Instance.StartGame();
        //Console.WriteLine(GameManger.Instance.Level);
        //GameManger.Instance.IncreaseLevel();
        //Console.WriteLine(GameManger.Instance.Level);
        #endregion

        #region Observer
        // Observer
        //Player player = new Player();
        //Enemy enemy = new Enemy();

        //Console.WriteLine("Player Speed : " + player.Speed);
        //Console.WriteLine(new String('-',100));

        //Console.WriteLine("Enemy Speed : "+ enemy.Speed);
        //Console.WriteLine(new String('-', 100));



        //GameManger.Instance.StartGame();
        //Console.WriteLine(new String('-', 100));

        //Console.WriteLine("Player Speed : " + player.Speed);
        //Console.WriteLine(new String('-', 100));

        //Console.WriteLine("Enemy Speed : " + enemy.Speed);
        //Console.WriteLine(new String('-', 100));

        //Console.ReadKey();
        #endregion

        // Strategy
        Player player = new Player();
        player.ChangeWeapon(new Vandal());
        Console.WriteLine(new String('-',100));
        player.Shoot();
        Console.WriteLine(new String('-', 100));
        player.ChangeWeapon(new Awp());
        player.Shoot();
        Console.WriteLine(new String('-', 100));
        player.ChangeWeapon(new Knife());
        player.Shoot();
        Console.WriteLine(new String('-', 100));
        Console.ReadKey();


    }


}



