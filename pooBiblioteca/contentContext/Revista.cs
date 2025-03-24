namespace pooBiblioteca.contentContext;

public class Revista : ItemBiblioteca
{
    public string Edicao { get; set; }
    public DateTime MesPublicacao { get; set; }
    public override void ExibirDetalhes()
    {
        Console.WriteLine($"Detalhes do Livro:" +
                          $"\nId:{Id}" +
                          $"\nTitulo: {Titulo}" +
                          $"\nAno de Publicação: {AnoPublicacao}" +
                          $"\nDisponível: {Disponivel}" +
                          $"\nEdição: {Edicao}" +
                          $"\nMesPublicacao: {MesPublicacao}");
    }
}