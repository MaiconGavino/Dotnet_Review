namespace DesafioSistemaLanchonete.ContentSales
{
    public class Salgado : Produto
    {
        public string Recheio { get; set; }
        public string TipoSalgado { get; set; }

        public Salgado(decimal valor, int peso, DateTime data, string recheio, string tipoSalgado)
        : base(valor, peso, data)
        {
            Recheio = recheio;
            TipoSalgado = tipoSalgado;
        }

        public override string Mostrar()
        {
            return $"Salgado de tipo {TipoSalgado}, recheio: {Recheio}, Validade {Validade:dd/MM/yyyy}, " +
                   $"Peso {PesoInGrama}, valor {Preco}";
        }
    }
}