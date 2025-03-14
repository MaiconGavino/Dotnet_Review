namespace horaDoPitch
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Title = "Hora do Pitch";
            Console.WriteLine("Digite o tempo em minutos: ");
            if (int.TryParse(Console.ReadLine(), out int tempo))
            {
                Alarme alarme = new Alarme();
                alarme.Tempo = tempo;
                alarme.Iniciar();
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro.");
            }
        }
    }
}