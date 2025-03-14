namespace pooAreaRetangulo
{
    class Program
    {
        public static void Main(string[] args)
        {
            //1- O usuário deverá informar para o programa a base e altura
            Console.WriteLine("Digite o valor da base: ");
            double baseR = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da altura: ");
            double alturaR = double.Parse(Console.ReadLine());

            Retangulo retangulo = new Retangulo(baseR, alturaR);
            retangulo.ExibirRetangulo();
        }
    }
}