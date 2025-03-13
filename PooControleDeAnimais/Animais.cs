namespace ControleDeAnimais;

public class Animal
{
    private String nome;

    public String Nome
    {
        get { return this.nome; }
        set { this.nome = value; }
    } 
    
    private String tipo;

    public String Tipo
    {
        get { return this.tipo; }
        set
        {
            String tipoLower = value.ToLower();
            if (tipoLower == "cachorro" || tipoLower == "gato" || tipoLower == "peixe")
            {
                tipo = value;
            }
            else
            {
                tipo = "peixe";
            }
        }
    }

    public Animal(String nome, String tipo)
    {
        this.Nome = nome.ToLower();
        this.Tipo = tipo.ToLower();
    }
}