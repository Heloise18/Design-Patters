public class MacFactory : IFactory
{
    public IButton Create()
    {
        Console.WriteLine("Botão Mac criado! ");
        return new MacButton();
    }
}