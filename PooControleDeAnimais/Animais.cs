namespace ControleDeAnimais;

public enum TipoAnimal {Cachorro, Gato, Peixe}
public class Animal
{
    private string nome;

    public String Nome
    {
        get { return nome; }
        set { nome = value; }
    } 
    
    private TipoAnimal tipo;

    public TipoAnimal Tipo
    {
        get { return tipo; }
        set { tipo = value; }
    }

    public Animal(string nome, TipoAnimal tipo)
    {
        this.nome = nome;
        this.tipo = tipo;
    }
}