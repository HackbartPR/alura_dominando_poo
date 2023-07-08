using ScreenSound.Modelos;
using ScreenSound.Menus;

// Criando Dicionario de Menus
Dictionary<int, Menu> opcoesMenu = new()
{
    { 1, new RegistrarBanda() },
    { 2, new RegistrarAlbum() },
    { 3, new MostrarBandas() },
    { 4, new AvaliarBanda() },
    { 5, new AvaliarAlbum() },
    { 6, new ExibirDetalhes() },
};

// Criando Lista de bandas
Dictionary<string, Banda> bandasRegistradas = new();

// Criando bandas
Banda ira = new ("Ira");
Banda beatles = new ("Beatles");

//Dando notas para as bandas
ira.AdicionarNota(new Avaliacao(10));
ira.AdicionarNota(new Avaliacao(8));
ira.AdicionarNota(new Avaliacao(6));

beatles.AdicionarNota(new Avaliacao(10));
beatles.AdicionarNota(new Avaliacao(9));
beatles.AdicionarNota(new Avaliacao(8));

// Adicionando bandas na lista
bandasRegistradas.Add(ira.Nome, ira);
bandasRegistradas.Add(beatles.Nome, beatles);

void ExibirLogo()
{
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine("Boas vindas ao Screen Sound 2.0!");
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para registrar o álbum de uma banda");
    Console.WriteLine("Digite 3 para mostrar todas as bandas");
    Console.WriteLine("Digite 4 para avaliar uma banda");
    Console.WriteLine("Digite 5 para avaliar um albúm");
    Console.WriteLine("Digite 6 para exibir os detalhes de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    if (!opcoesMenu.ContainsKey(opcaoEscolhidaNumerica))
    {
        Console.WriteLine("Opção inválida");
        Console.Clear();
        ExibirOpcoesDoMenu();
    }

    if (opcaoEscolhidaNumerica == -1)
    {
        Console.WriteLine("Até mais");
        return;
    }

    Menu menu = opcoesMenu[opcaoEscolhidaNumerica];
    menu.Executar(bandasRegistradas);

    ExibirOpcoesDoMenu();
}

ExibirOpcoesDoMenu();