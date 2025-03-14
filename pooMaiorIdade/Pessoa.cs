namespace pooMaiorIdade;

public class Pessoa
{
    private string nome;
    public String Nome { get => nome; set => nome = value.ToUpper(); }
    private int idade;
    public int Idade { get => idade; set => idade = value; }

    public Pessoa(String nome, int idade)
    {
        this.Nome = nome;
        this.Idade = idade;
    }
    public void ExibirDados()
    {
        Console.WriteLine($"\nA pessoa com a maior idade se chama: {Nome}");
    }
}