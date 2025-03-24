namespace pooBiblioteca.contentContext;

public enum Generos
{
    Terror, Suspence, Kids, Comédia, Documentários, Outros
}

public class Dvds : ItemBiblioteca
{
    public int DuracaoMinutos { get; set; }
    public Generos Genero { get; set; }
    public override void ExibirDetalhes()
    {
        Console.WriteLine($"Detalhes do Livro:" +
                          $"\nId:{Id}" +
                          $"\nTitulo: {Titulo}" +
                          $"\nAno de Publicação: {AnoPublicacao}" +
                          $"\nDisponível: {Disponivel}" +
                          $"\nDuração: {DuracaoMinutos}" +
                          $"\nGenero: {Genero}");
    }
}