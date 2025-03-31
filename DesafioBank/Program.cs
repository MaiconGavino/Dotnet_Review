namespace DesafioBank
{
    class Program
    {
        public static void Main(string[] args)
        {
            Conta conta = new Conta(3341, 876672, 189.90);
            conta.Extrato();
            conta.Sacar(23.60);
            conta.Depositar(1.04);
            conta.Extrato();
        }
    }
}