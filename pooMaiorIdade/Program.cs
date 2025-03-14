namespace pooMaiorIdade
{
    class program
    {
        public static void Main(string[] args)
        {
            List<Pessoa> pessoas = new List<Pessoa>();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Digite o nome do pessoa: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Digite o idade: ");
                int idade = int.Parse(Console.ReadLine());
                pessoas.Add(new Pessoa(nome, idade));
            }

            if (pessoas[0].Idade > pessoas[1].Idade && pessoas[0].Idade > pessoas[2].Idade)
            {
                pessoas[0].ExibirDados();
            }
            else if (pessoas[1].Idade > pessoas[2].Idade)
            {
                pessoas[1].ExibirDados();
            }
            else if (pessoas[1].Idade < pessoas[2].Idade)
            {
                pessoas[2].ExibirDados();
            }
            else
            {
                Console.WriteLine("Todas as pessoas possuem a mesma idade.");
            }
            
        }
    }
}

