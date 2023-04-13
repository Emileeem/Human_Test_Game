using System;

public abstract class Individuals
{
    public int Coins = 10;

    public abstract bool Interact ();

    public void Azar()
    {
        Random random = new Random();

        int azar = random.Next(100);

        if(azar < 10)
            Coins--;
        
    }
    public virtual void Cheat (){ }
    public virtual void Help (){ } 
    public abstract Individuals Clone ();

    
}