using System;
using System.Threading;

namespace horaDoPitch;

public class Alarme
{
    private int _tempo;

    public int Tempo
    {
        get { return _tempo; }
        set { _tempo = 1000 * 60 * value; }
    }

    public Alarme()
    {
        Tempo = 3; // três minutos
        Efeito = 250;
    }

    public int Efeito { get; set; }

    public void Iniciar()
    {
        Thread.Sleep(_tempo);
        try
        {
            Console.Beep(Efeito, _tempo);
        }
        catch (PlatformNotSupportedException)
        {
            Console.WriteLine("Platform Not Supported");
        }
    }
    
}