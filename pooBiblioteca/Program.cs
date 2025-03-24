namespace pooBiblioteca;
using contentContext;

class Program
{
    public static void Main(string[] args)
    {
        Livros livro1 = new Livros();
        livro1.Autor = "João Gular";
        livro1.Editora = "Terra";
        livro1.Titulo = "Post a la livro";
        livro1.AnoPublicacao = "2023";
        livro1.ExibirDetalhes();
        
        Revista revista1 = new Revista();
        revista1.Titulo = "Superinteressante";
        revista1.AnoPublicacao = "2025";
        revista1.Edicao = "Navios de Guerra";
        revista1.MesPublicacao = Mes.Abril;
        revista1.ExibirDetalhes();
        
        Dvds dvd1 = new Dvds();
        dvd1.Titulo = "Game of Thrones";
        dvd1.AnoPublicacao = "2024";
        dvd1.DuracaoMinutos = 134;
        dvd1.Genero = Generos.Comédia;
        dvd1.ExibirDetalhes();

    }
    
}