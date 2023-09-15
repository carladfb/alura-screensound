using Screensound.Modelos;

namespace Screensound.Menus;
internal class MenuRegistrarAlbum : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirLogoApenas();
        ExibirTituloDaOpcao("Registro de álbuns");
        Console.Write("Digite a banda cujo álbum deseja registrar: ");
        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Console.Write("Digite o título do álbum: ");
            string tituloAlbum = Console.ReadLine()!;
            Banda banda = bandasRegistradas[nomeDaBanda];
            banda.AdicionarAlbum(new Album(tituloAlbum));
            Console.WriteLine($"O álbum {tituloAlbum} de {nomeDaBanda} foi registrado com sucesso!");
            Thread.Sleep(3000);
            Console.Clear();
        }
        else
        {
            Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
            Console.WriteLine("\nDigite Enter para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }
}