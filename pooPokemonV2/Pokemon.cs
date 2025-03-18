namespace pooPokemonV2;

public class Pokemon
{
    public string Name { get; set; }
    public string Tipo { get; set; }

    public Pokemon(string nome, string tipo)
    {
        Name = nome;
        Tipo = tipo;
    }

    public Pokemon()
    {
        Name = "";
        Tipo = "";
    }

    public void ExibirDados()
    {
        Console.WriteLine($"Nome do Pokemon: {Name} e seu tipo é: {Tipo}");
    }
}