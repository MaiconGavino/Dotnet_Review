using System.Data;

namespace pooAreaRetangulo;

public class Retangulo
{
    private double baseR;

    public double BaseR
    {
        get => baseR;
        set => baseR = value;
    }
    private double altura;

    public double AlturaR
    {
        get => altura;
        set => altura = value;
    }

    private double area;
    public double Area
    {
        get => area;
        set => area = value;
    }

    public void ExibirRetangulo()
    {
        Console.WriteLine($"Base: {BaseR}");
        Console.WriteLine($"Altura: {AlturaR}");
        Console.WriteLine($"Área: {Area}");
        
    }

    public Retangulo(double baseR, double altura)
    {
        this.BaseR = baseR;
        this.AlturaR = altura;
        this.Area = baseR * altura;
    }
}