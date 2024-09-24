namespace BasicsCSharp;

public static class OperacoesMatematicas
{
    public static int AdicionarInline(int val1, int val2) => val1 + val2;

    public static (int resultadoAdicao, string nome) AdicionarMultipleReturn(int val1, int val2)
    {
        var resultado = val1 + val2;

        return (resultado, "Mazzo");
    }

    public static void optionalParams(double val1, double val2 = 0)
    {
        Console.WriteLine($"val1: {val1} | val2: {val2}");        
    }
    
}