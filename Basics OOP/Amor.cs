namespace Basics_OOP;

public class Amor
{
    private int GOOD_GUY_AMOR_POINTS = 5;
    private int BAD_GUY_AMOR_POINTS = 5;

    public int AmorPoints { get; set; }

    public Amor(Faction faction)
    {
        switch (faction)
        {
            case Faction.GoodGuys:
                AmorPoints = GOOD_GUY_AMOR_POINTS;
                break;
            case Faction.BadGuys:
                AmorPoints = BAD_GUY_AMOR_POINTS;
                break;
        }
    }
}