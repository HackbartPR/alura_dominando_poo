namespace ScreenSound.Menus;

using ScreenSound.Modelos;

internal class RegistrarBanda : Menu
{
    public override void Executar (Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        this.ExibirTituloDaOpcao("Registro das bandas");

        Console.Write("Digite o nome da banda que deseja registrar: ");
        string nomeDaBanda = Console.ReadLine()!;

        Banda bandaNova = new(nomeDaBanda);
        bandasRegistradas.Add(nomeDaBanda, bandaNova);

        Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
        Thread.Sleep(4000);
        Console.Clear();
    }
}
