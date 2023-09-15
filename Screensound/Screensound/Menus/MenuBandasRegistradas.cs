using Screensound.Modelos;

namespace Screensound.Menus;
internal class MenuBandasRegistradas : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirLogoApenas();
        ExibirTituloDaOpcao("Exibindo todas as bandas registradas na nossa aplicação");

        foreach (string banda in bandasRegistradas.Keys)
        {
            Console.WriteLine($"Banda: {banda}");
        }

        Console.WriteLine("\nDigite Enter para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
    }
}