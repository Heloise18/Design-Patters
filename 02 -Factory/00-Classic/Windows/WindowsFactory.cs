public class WindowsFactory : IFactory
{
    public IButton Create()
    {
        Console.WriteLine("Botao Windos criado com sucesso");
        return new WindowsButton();
    }
}