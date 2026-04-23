public class Combate : IComportamento
{
    public void Probality()
    {
        Console.WriteLine("COMBATE....\n");
        
        int probablidade = Random.Shared.Next(0,100);

        if(probablidade <= 5)
            new Hackeado();
        
    }
}