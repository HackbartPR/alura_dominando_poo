namespace ScreenSound.Menus;

using ScreenSound.Modelos;

internal class ExibirDetalhes : Menu
{    
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        this.ExibirTituloDaOpcao("Exibir detalhes da banda");

        Console.Write("Digite o nome da banda que deseja conhecer melhor: ");
        string nomeDaBanda = Console.ReadLine()!;

        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {           
            Console.WriteLine($"\nBanda {nomeDaBanda}");
            Console.WriteLine($"\nAlbuns:");

            bandasRegistradas[nomeDaBanda].Albuns.ForEach(album => Console.WriteLine($"Albúm: {album.Nome} -> Média {album.Media}"));

            Console.WriteLine($"\nA média da banda {nomeDaBanda} é {bandasRegistradas[nomeDaBanda].Media}.");
            Console.WriteLine("\nDigite uma tecla para votar ao menu principal");
        }
        else
        {
            Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        }

        Console.ReadKey();
        Console.Clear();
    }
}
