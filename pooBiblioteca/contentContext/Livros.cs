namespace pooBiblioteca.contentContext;

public class Livros : ItemBiblioteca
{
    public string Autor { get; set; }
    public string Editora { get; set; }

    public override void ExibirDetalhes()
    {
        Console.WriteLine($"Detalhes do Livro:" +
                          $"\nId:{Id}" +
                          $"\nTitulo: {Titulo}" +
                          $"\nAno de Publicação: {AnoPublicacao}" +
                          $"\nDisponível: {Disponivel}" +
                          $"\nAutor: {Autor}" +
                          $"\nEditora: {Editora}");
    }
}