namespace ScreenSound.Modelos;

internal class Album: IAvaliavel
{
    private List<Musica> musicas = new List<Musica>();
    private List<Avaliacao> notas = new();

    public static int qntAlbum = 0;
    public string Nome { get; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);
    public List<Musica> Musicas => musicas;
    public Album(string nome)
    {
        Nome = nome;

        qntAlbum++;
    }
    public double Media
    {
        get
        {
            return notas.Count > 0 ? notas.Average(nota => nota.Nota) : 0;
        }
    }

    public void AdicionarNota(Avaliacao nota)
    {
        notas.Add(nota);
    }

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Lista de músicas do álbum {Nome}:\n");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Música: {musica.Nome}");
        }
        Console.WriteLine($"\nPara ouvir este álbum inteiro você precisa de {DuracaoTotal}");
    }
}