namespace Basics_OOP;

public class Weapon
{
   private int GOOD_GUY_DAMAGE = 10;
   private int BAD_GUY_DAMAGE = 9;
   public int Damage { get; set; }
   public int ArmorPoints { get; set; }

   public Weapon(Faction faction)
   {
      switch (faction)
      {
         case Faction.GoodGuys:
            Damage = GOOD_GUY_DAMAGE;
            break;
         case Faction.BadGuys:
            Damage = BAD_GUY_DAMAGE;
            break;
      }
   }
}