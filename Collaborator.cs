public class Collaborator : Individuals
{
    public override Individuals Clone()
    {
        Collaborator coll = new Collaborator();
        
        coll.Coins = 10;
        this.Coins = 10;

        return coll;  
    }

    public override bool Interact()
    {
        return true;
    }
}