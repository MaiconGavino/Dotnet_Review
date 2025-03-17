namespace pooPokemon;

public class Pokemon
{
    public string Nome {get; set;}
    public string Desc {get; set;}
    public Pokemon(string nome, string desc)
    {
        Nome = nome;
        Desc = desc;
    }

    public Pokemon() : this("", "") { }
    public void ExibirDados()
    {
        Console.WriteLine($"O nome do Pokemon é {Nome} e sua descrição é {Desc}");
    }
}