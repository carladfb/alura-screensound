using Screensound.Modelos;

namespace Screensound.Menus;
internal class MenuSair : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.WriteLine("Até mais :)");
    }
}