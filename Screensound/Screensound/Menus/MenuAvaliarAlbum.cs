using Screensound.Modelos;

namespace Screensound.Menus;
internal class MenuAvaliarAlbum : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);

        ExibirLogoApenas();
        ExibirTituloDaOpcao("Avaliar álbum");
        Console.Write("Digite o nome da banda que deseja avaliar: ");
        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Banda banda = bandasRegistradas[nomeDaBanda];
            Console.Write("Digite o título do álbum: ");
            string tituloAlbum = Console.ReadLine()!;
            if (banda.Albuns.Any(a => a.Nome.Equals(tituloAlbum)))
            {
                Album album = banda.Albuns.First(a => a.Nome.Equals(tituloAlbum));
                Console.Write($"Qual a nota que o álbum {tituloAlbum} merece: ");
                Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
                album.AdicionarNota(nota);
                Console.WriteLine($"\nA nota {nota.Nota} foi registrada com sucesso para o álbum {tituloAlbum}");
                Thread.Sleep(1500);
                Console.Clear();
            }else
            {
                Console.WriteLine($"\nO álbum {tituloAlbum} não foi encontrado!");
                Console.WriteLine("\nDigite Enter para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
            }
        }
       
    }
}

