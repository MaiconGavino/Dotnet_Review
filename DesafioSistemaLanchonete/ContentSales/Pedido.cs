using System.Text;

namespace DesafioSistemaLanchonete.ContentSales
{
    class Pedido
    {
        public string NomeCliente { get; set; }
        public double Taxa => 0.10;
        public List<Produto> Items { get; set; } = new List<Produto>();

        public Pedido(string nome)
        {
            NomeCliente= nome;
        }

        public void AdicionarProduto(Produto produto)
        {
            Items.Add(produto);
        }

        public double CalcularPreco()
        {
            double total = 0;
            foreach (var item in Items)
            {
                total += (double)item.Preco;
            }
            return total + (total * Taxa);
        }

        public double CalcularTroco(double pagamento)
        {
            double total = CalcularPreco();
            if (total > pagamento)
            {
                throw new ArgumentException("Valor recebido é menor que o total do pedido.");

            }
            return pagamento - total;
        }

        public string GerarNotaFiscal()
        {
            StringBuilder notaFiscal = new StringBuilder();
            notaFiscal.AppendLine("------- Nota Fiscal -------");
            notaFiscal.AppendLine($"Cliente: {NomeCliente}");
            notaFiscal.AppendLine("Itens:");
            foreach (var item in Items)
            {
                notaFiscal.AppendLine($" - {item.Mostrar()}");
            }
            notaFiscal.AppendLine($"Taxa de {Taxa:P}");
            notaFiscal.AppendLine($"Consumo Total: {CalcularPreco():C}");
            return notaFiscal.ToString();
                
        }
        
    }
}