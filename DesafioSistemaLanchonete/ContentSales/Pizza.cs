namespace DesafioSistemaLanchonete.ContentSales
{
    class Pizza : Produto
    {
        public string Molho  { get; set; }
        public string Recheio { get; set; }
        public string Borda { get; set; }

        public Pizza(decimal valor, int peso, DateTime data, string molho, string recheio, string borda)
        : base(valor, peso, data)
        {
            Molho = molho;
            Recheio = recheio;
            Borda = borda;
        }

        public override string Mostrar()
        {
            return $"Pizza com molho : {Molho}, recheio: {Recheio}, borda: {Borda}," +
                   $" com peso {PesoInGrama}, preço {Preco}, validade {Validade:dd/MM/yyyy}";
        }

    }
}