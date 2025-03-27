namespace DesafioSistemaLanchonete.ContentSales
{
    public abstract class Produto
    {
        public decimal Preco { get; set; }
        public int PesoInGrama { get; set; }
        public DateTime Validade { get; set; }

        public Produto(decimal preco, int pesoInGrama, DateTime validade)
        {
            Preco = preco;
            PesoInGrama = pesoInGrama;
            Validade = validade;
        }

        public abstract string Mostrar();
    }
}