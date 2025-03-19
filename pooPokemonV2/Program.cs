namespace pooPokemonV2
{
    class program
    {
        public static void Main(string[] args)
        {
            Pokedex pokedex = new Pokedex();
            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("Bem-vindo à Pokedex Interativa!\nSelecione uma opção:\n1 - Adicionar Pokémon\n2 - Visualizar Pokémons\n3 - Atualizar Pokémon\n4 - Remover Pokémon\n5 - Sair");
                int opcao = Convert.ToInt32(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                    {
                        Console.WriteLine("Informe o nome do pokemon: ");
                        string nome = Console.ReadLine();
                        Console.WriteLine("Informe o tipo do pokemon: ");
                        string tipo = Console.ReadLine();
                        pokedex.AddPokemon(nome, tipo);
                        break;
                    }
                    case 2:
                    {
                        pokedex.ExibirPokemons();
                        break;
                    }
                    case 3:
                    {
                        Console.WriteLine("Informe o nome do pokemon que deseja alterar:");
                        string nome = Console.ReadLine();
                        Console.WriteLine("Informe o novo tipo do pokemon: ");
                        string novoTipo = Console.ReadLine();
                        pokedex.AlterarPokemon(nome, novoTipo);
                        break;
                    }
                    case 4:
                    {
                        Console.WriteLine("Informe o nome do pokemon que deseja remover:");
                        string nome = Console.ReadLine();
                        pokedex.DeletePokemon(nome);
                        break;
                    }
                    case 5:
                    {
                        continuar = false;
                        break;
                    }
                    default:
                        Console.WriteLine("Opção não valida. Tente novamente...");
                        break;
                }

            }
        }
    }
}