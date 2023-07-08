using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class AvaliarAlbum : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);

        this.ExibirTituloDaOpcao("Avaliar banda");

        Console.Write("Digite o nome da banda que deseja avaliar: ");
        string nomeDaBanda = Console.ReadLine()!;

        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Banda banda = bandasRegistradas[nomeDaBanda];

            Console.Write("Agora digite o título do álbum: ");
            string tituloAlbum = Console.ReadLine()!;

            if (banda.Albuns.Any(album => album.Nome.Equals(tituloAlbum)))
            {
                Album album = banda.Albuns.First(album => album.Nome.Equals(tituloAlbum));

                Console.Write($"Qual a nota que o album {album.Nome} da banda {nomeDaBanda} merece: ");
                Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);

                album.AdicionarNota(nota);
                Console.WriteLine($"\nA nota {nota.Nota} foi registrada com sucesso para o albúm {tituloAlbum}");

                Thread.Sleep(2000);
            } else
            {
                Console.WriteLine($"\nO Album {tituloAlbum} da abnda {nomeDaBanda} não foi encontrada!");
                Console.WriteLine("Digite uma tecla para voltar ao menu principal");

                Console.ReadKey();
            }            
        }
        else
        {
            Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");

            Console.ReadKey();
        }

        Console.Clear();
    }

}
