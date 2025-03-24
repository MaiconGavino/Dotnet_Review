namespace pooBiblioteca.contentContext;

public enum Mes
{
    Janeiro, Fevereiro, Março, Abril, Maio, Junho,  Julho, Agosto, Setembro, Outubro, Novembro, Dezembro
}

public class Revista : ItemBiblioteca
{
    public string Edicao { get; set; }
    public Mes MesPublicacao { get; set; }
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