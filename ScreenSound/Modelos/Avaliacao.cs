namespace ScreenSound.Modelos;

internal class Avaliacao
{
    public int Nota { get; }

    public Avaliacao (int nota)
    {
        this.Nota = nota;
    }

    public static Avaliacao Parse (string texto)
    {
        return new Avaliacao(int.Parse(texto));
    }
}