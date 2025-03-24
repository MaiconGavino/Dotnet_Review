using System.Text.Json.Serialization;

namespace pooBiblioteca.contentContext;

[JsonPolymorphic(TypeDiscriminatorPropertyName = "$type")]
[JsonDerivedType(typeof(Livros), "livros")]
[JsonDerivedType(typeof(Revista), "revista")]
[JsonDerivedType(typeof(Dvds), "dvds")]
public interface IEmprestavel
{
    void Emprestar();
    void Devolver();
}
public abstract class ItemBiblioteca : IEmprestavel
{
    private static int contador = 0;
    protected int Id { get;  }
    public string Titulo { get; set; }
    public string AnoPublicacao { get; set; }
    protected bool Disponivel { get; set; }

    public abstract void ExibirDetalhes();

    public ItemBiblioteca()
    {
        Id = contador++;
        Disponivel = true;
    }


    public virtual void Emprestar()
    {
        if (Disponivel)
        {
            Disponivel = false;
            Console.WriteLine("Item emprestado com sucesso.");
        }
        else
        {
            Console.WriteLine("Item não está disponível para empréstimo.");
        }
    }

    public virtual void Devolver()
    {
        if (!Disponivel)
        {
            Disponivel = true;
            Console.WriteLine("Item devolvido com sucesso.");
        }
        else
        {
            Console.WriteLine("O Item está disponível para empréstimo.");
        }
        
    }
}