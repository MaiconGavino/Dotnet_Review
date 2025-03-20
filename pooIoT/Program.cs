namespace pooIoT
{
    class program
    {
        public static void Main(string[] args)
        {
            Lampada lampada = new Lampada("Sala");
            lampada.Ligar();
            lampada.Desligar();
        }
    }
}