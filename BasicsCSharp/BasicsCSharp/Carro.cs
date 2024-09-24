namespace BasicsCSharp;

public class Carro
{
    public string Modelo { get; set; }
    public DateOnly LancadoEm { get; set; }
    public Cor Cor { get; set; }

    public Carro(String modelo)
    {
        Modelo = modelo;
    }
    
    public void Detalhes() => Console.WriteLine($"O carro {Modelo} foi lancado em {LancadoEm} e possui a cor {Cor}.");
}
