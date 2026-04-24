
public class LinuxFatcory : IFactory
{
    public IButton Create()
    {
        Console.WriteLine("Butao linux criado com sucesso! ");
        return new LinuxButton();
    }
}
