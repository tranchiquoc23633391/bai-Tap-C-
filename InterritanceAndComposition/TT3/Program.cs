using System;



public class Player : IDamageable, IDestroy
{
    private int health;

    public Player(int initialHealth)
    {
        health = initialHealth;
    }

    public void TakeDamage(int amount)
    {
        health -= amount;
        if (health < 0)
            health = 0;

        if (health == 0)
            Dead();
    }

    private void Dead()
    {
        Console.WriteLine("PLAYER IS DEAD");
    }

    public void Destroy()
    {
        Console.WriteLine("Player has been destroyed");
        health = 0;
    }
}

// Test
class Program
{
    static void Main()
    {
        Player p = new Player(100);
        p.TakeDamage(50);
        p.TakeDamage(60); // sẽ gọi Dead()
        p.Destroy();      // huỷ player
    }
}
