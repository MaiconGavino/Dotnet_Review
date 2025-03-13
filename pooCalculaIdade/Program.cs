namespace pooCalculaIdade
{
    class Program
    {
        public static void Main(string[] args)
        {
            Pessoa p = new Pessoa();
            p.Nome = "Maicon";
            p.Ano = Convert.ToInt32(1997);
            p.ExibirDados();
        }
    }
}