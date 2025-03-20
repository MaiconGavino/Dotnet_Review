namespace pooIoT
{
    public abstract class Dispositivos : IDispositivos
    {
        public string Nome { get; set; }
        public bool Status {get; set;}

        public event EventHandler StatusAlterado;

        public Dispositivos(string nome)
        {
            Nome = nome;
            Status = false;
        }
        public virtual void Ligar()
        {
            Status = true;
            StatusAlterado?.Invoke(this, EventArgs.Empty);
            Console.WriteLine($"Dispositivos: {Nome} foi ligado");
        }

        public virtual void Desligar()
        {
            Status = false;
            StatusAlterado?.Invoke(this, EventArgs.Empty);
            Console.WriteLine($"Dispositivos: {Nome} foi desligado");
        }
    }

    public class Lampada : Dispositivos
    {
        public Lampada(string nome) : base(nome) { }

        public override void Ligar()
        {
            base.Ligar();
        }

        public override void Desligar()
        {
            base.Desligar();
        }
    }

    public interface IDispositivos
    {
        public string Nome { get; set; }
        protected bool Status { get; set; }

        public event EventHandler StatusAlterado;
    }
}


