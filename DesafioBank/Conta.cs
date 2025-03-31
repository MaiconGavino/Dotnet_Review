namespace DesafioBank;

public class Conta
{
    public int CondigoBank { get; set; }
    public int NumeroConta { get; set; }
    public double Saldo { get; set; }

    public Conta(int condigoBank, int numeroConta, double saldo)
    {
        CondigoBank = condigoBank;
        NumeroConta = numeroConta;
        Saldo = saldo;
    }
    public void Depositar(double valor)
    {
        if (ValidarValor(valor))
        {
            Saldo += valor; 
            Console.WriteLine($"Deposito de R${valor}, saldo do conta {Saldo}");
        }
    }

    public void Sacar(double valor)
    {
        if (ValidarValor(valor))
        {
            if (Saldo >= valor)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de R${valor}, saldo conta R${Saldo}");
            }
            else
            {
                Console.WriteLine($"Valor inferior ao existente em conta, seu saldo é de R${Saldo}");
            }
        }
    }

    private bool ValidarValor(double valor)
    {
        return valor >= 0;
    }
    public void Extrato ()
    {
        Console.WriteLine($"Saldo do conta R${Saldo}");
    }
}