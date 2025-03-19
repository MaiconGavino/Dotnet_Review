using System.Security.Cryptography.X509Certificates;

namespace ControleDeAnimais
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Animal> animais = new List<Animal>();
            
            Console.Write("Quantos animais você deseja cadastrar? ");
            if (!int.TryParse(Console.ReadLine(), out int numeroDeAnimais) || numeroDeAnimais <= 0)
            {
                Console.WriteLine("Numero de animais invalido");
                return;
            }

            for (int i = 0; i < numeroDeAnimais; i++)
            {
                Console.WriteLine($"\nCadastro do animais {i+1}:");
                Console.Write("Digite o nome do animal: ");
                string nome = Console.ReadLine();
                TipoAnimal tipo;
                while (true)
                {
                    Console.Write("Tipo (Cachorro, Gato ou Peixe): ");
                    string tipoInput = Console.ReadLine();
                    if (Enum.TryParse(tipoInput, true, out tipo) && Enum.IsDefined(typeof(TipoAnimal), tipo))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Tipo inválido. Por favor, digite 'Cachorro', 'Gato' ou 'Peixe'.");
                    }
                }

                animais.Add(new Animal(nome, tipo));
            }

            int totalCachorros = 0;
            int totalGatos = 0; 
            int totalPeixes = 0;

            foreach (var animal in animais)
            {
                switch (animal.Tipo)        
                {
                    case TipoAnimal.Cachorro:
                        totalCachorros++;
                        break;
                    case TipoAnimal.Gato:
                        totalGatos++;
                        break;
                    case TipoAnimal.Peixe:
                        totalPeixes++;
                        break;
                }
            }
            
            Console.WriteLine($"Total cachorros: {totalCachorros}");
            Console.WriteLine($"Total gatos: {totalGatos}");
            Console.WriteLine($"Total peixes: {totalPeixes}");
            
        }
    }
}