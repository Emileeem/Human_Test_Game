public class Tolerant : Individuals
{
    int enganado = 3;
    int enganando = 0;

    public override Individuals Clone()
    {
        Tolerant tol = new Tolerant();
        
        tol.Coins = 10;
        this.Coins = 10;

        return tol;     
    }

    public override bool Interact()
    {
        if (enganando > 0)
        {
            enganando --;
            return false;
            
        }
        return true;
    }
}