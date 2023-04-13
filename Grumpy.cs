public class Grumpy : Individuals
{
    int enganado = 0;

    public override Individuals Clone()
    {
        Grumpy gump = new Grumpy();
        
        gump.Coins = 10;
        this.Coins = 10;

        return gump;     
    }

    public override bool Interact()
    {
        if (enganado > 1)
        {
            enganado --;
            return false;
            
        }
        return true;
    }
}