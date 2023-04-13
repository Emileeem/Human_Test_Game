public class CopyCat : Individuals
{


    public override Individuals Clone()
    {
        CopyCat copCat = new CopyCat();
        
        copCat.Coins = 10;
        this.Coins = 10;

        return copCat;  
    }

    public override bool Interact()
    {
        return true;
    }
}