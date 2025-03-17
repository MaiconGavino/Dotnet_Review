namespace pooPokemon;

class Program
{
    public static void Main(string[] args)
    {
        Pokedex pokedex = new Pokedex();
        bool continuar = true;
        while (continuar)
        {
            Console.WriteLine("Bem vindo a Pokdex \nSelecione uma das opções abaixo: \n1 - Adicionar Pokemon \n2 - Listar Pokemons \n3 - Sair");
            Console.Write("Informe a opço desejada: ");
            if (!int.TryParse(Console.ReadLine(), out int opcao))
            {
                Console.WriteLine("Opção inválida. Tente novamente...");
                continue;
            }

            switch (opcao)
            {
                case 1:
                    Console.Write("Digite o nome do Pokemon: ");
                    string nome = Console.ReadLine();
                    Console.Write("Digite a descricao do Pokemon: ");
                    string desc = Console.ReadLine();
                    pokedex.AddPokemon(nome, desc);
                    break;
                case 2:
                    pokedex.ExibirPokemons();
                    break;
                case 3:
                    continuar = false;
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente...");
                    break;
            }
        }
    }
}