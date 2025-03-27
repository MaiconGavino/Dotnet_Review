using DesafioSistemaLanchonete.ContentSales;

namespace DesafioSistemaLanchonete
{
    class Program
    {
        public static void Main(string[] args)
        {
            Pedido pedido = new Pedido("João Felipe");
            
            Pizza pizza = new Pizza(Convert.ToDecimal(12.90), 500, Convert.ToDateTime("25-01-2025"), "Picante",
                "Frango com Catupiri", "Borda Recheada com Catupiri" );
            pedido.AdicionarProduto(pizza);
            
            
            Salgado salgado = new Salgado(Convert.ToDecimal(9.90), 450, 
                Convert.ToDateTime("25-01-2025"), "frango, queijo, pizza", "Assado" );
            pedido.AdicionarProduto(salgado);

            Lanche lanche = new Lanche(Convert.ToDecimal(11.90), 500,Convert.ToDateTime("25-01-2025"),
                "brioche", "Salada, 2hamburgue, frango, batata palha", "Molho da Casa");
            pedido.AdicionarProduto(lanche);
            
            Console.WriteLine(pedido.CalcularPreco());
            Console.WriteLine(pedido.CalcularTroco(50.0));
            
            Console.WriteLine(pedido.GerarNotaFiscal());
        }
    }
}