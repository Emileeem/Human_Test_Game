public class Cheater : Individuals
{


    public override Individuals Clone()
    {
        Cheater cheat = new Cheater();
        
        cheat.Coins = 10;
        this.Coins = 10;

        return cheat;  
    }

    public override bool Interact()
    {
        return false;
    }
}