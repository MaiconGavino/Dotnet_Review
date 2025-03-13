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
                Console.Write("Tipo (cachorro, gato ou peixe): ");
                string tipo = Console.ReadLine();
                
                animais.Add(new Animal(nome, tipo));
            }

            int totalCachorros = 0;
            int totalGatos = 0; 
            int totalPeixes = 0;

            foreach (var animal in animais)
            {
                switch (animal.Tipo)        
                {
                    case "cachorro":
                        totalCachorros++;
                        break;
                    case "gato":
                        totalGatos++;
                        break;
                    case "peixe":
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