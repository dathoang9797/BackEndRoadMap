using Basics_OOP;

var rng = new Random();
var goodGuy = new Warrior("Bob", Faction.GoodGuys);
var badGuy = new Warrior("Joe", Faction.BadGuys);

while (goodGuy.IsAlive && badGuy.IsAlive)
{
    if (rng.Next(0, 10) < 5)
    {
        goodGuy.Attack(badGuy);
    }
    else
    {
        badGuy.Attack(goodGuy);
    }
    Thread.Sleep(100);
}