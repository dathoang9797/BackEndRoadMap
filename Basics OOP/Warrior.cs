namespace Basics_OOP;

public class Warrior
{
    private const int GOOD_GUY_STARTING_HEALTH = 20;
    private const int BAD_GUY_STARTING_HEALTH = 20;

    public readonly Faction FACTION;

    public int Health { get; set; }
    public string Name { get; set; }
    public bool IsAlive { get; set; }

    public Weapon Weapon { get; set; }
    public Amor Amor { get; set; }

    public Warrior(string name, Faction faction)
    {
        Name = name;
        FACTION = faction;
        IsAlive = true;

        switch (faction)
        {
            case Faction.GoodGuys:
                Weapon = new Weapon(faction);
                Amor = new Amor(faction);
                Health = GOOD_GUY_STARTING_HEALTH;
                break;
            case Faction.BadGuys:
                Weapon = new Weapon(faction);
                Amor = new Amor(faction);
                Health = BAD_GUY_STARTING_HEALTH;
                break;
        }
    }

    public void Attack(Warrior enemy)
    {
        var damage = Weapon.Damage / enemy.Amor.AmorPoints;
        enemy.Health -= damage;
        AttactResult(enemy, damage);
    }

    private void AttactResult(Warrior enemy, int damage)
    {
        if (enemy.Health <= 0)
        {
            enemy.IsAlive = false;
            Tools.ColorWriteLine($"{enemy.Name} has been defeated!", ConsoleColor.Red);
            Tools.ColorWriteLine($"{Name} wins!", ConsoleColor.Green);
        }
        else
        {
            Tools.ColorWriteLine(
                $"{Name} attacks {enemy.Name} for {damage} damage! {enemy.Name} has {enemy.Health} health left.",
                ConsoleColor.Blue);
        }
    }
}