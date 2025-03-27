namespace DesafioSistemaLanchonete.ContentSales;

public class Lanche : Produto
{
    public string Pao { get; set; }
    public string Recheio { get; set; }
    public string Molho { get; set; }

    public Lanche(decimal preco, int peso, DateTime data, string pao, string recheio, string molho)
    :base(preco,peso,data)
    {
        Pao = pao;
        Recheio = recheio;
        Molho = molho;
    }

    public override string Mostrar()
    {
        return $"Lanche com pão {Pao}, recheio {Recheio}, Molho {Molho}, " +
               $"valor {Preco}, validade {Validade:dd/MM/yyyy}, e peso {PesoInGrama}";
    }
}