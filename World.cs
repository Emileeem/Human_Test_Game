using System;

World mundo = new World();

class World
{
    public List <Individuals> people = new List<Individuals>();
    public int Population => people.Count;
    public int RoundCount{get; private set;} = 0;

    bool Cheat;

    public void Interagir()
    {
        int len = people.Count;

        int index = Random.Shared.Next(len);
        var indA = people[index];

        index = (index + Random.Shared.Next(len) -1);
        var indB = people[index];

    }
    public void Add(Individuals individuo, int quantity = 1)
    {
        this.people.Add(individuo);
        for (int i = 0; i < quantity; i++)
        {
            var newInd = individuo.Clone();
            this.people.Add(newInd);
        }
    }
    public bool Round()
    {
        if(Population < 2)
            return false;
        this.RoundCount++;

        int steps = Population /2;
        for (int i=0; i < steps; i++)
            Interagir();
    }
    public bool Is_Cheat_Grumpy()
    {
        if(Cheat == true)
            return false;
        else 
            return true;
    }
}
