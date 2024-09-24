using System.Globalization;

namespace BasicsCSharp;

class Program
{
    enum DifficultyLevel
    {
        Low = 0,
        Medium = 1,
        High = 2
    }

    static void Main()
    {
        string text = "O usuário {0} gosta do numero {1}";
        string result = string.Format(text, "João Mazzo", 8);
        Console.WriteLine(result);



        DateOnly day = new DateOnly(2023, 12, 1);
        string dayInText = day.ToString("dd MMMM yyyy", new CultureInfo("pt-BR"));
        Console.WriteLine(dayInText);

        DateTime dateAndTime = new DateTime(2023, 12, 1, 20, 07, 1);
        DateTime dateAndTimeNow = DateTime.Now;
        DateTime dateAndTimeUtc = DateTime.UtcNow;
        DateTime dateToday = DateTime.Today;

        DateTime datePlusDays = dateAndTimeNow.AddDays(2);



        DifficultyLevel difficultyLevel = DifficultyLevel.Low;
        int difficultyLevelInt = (int)difficultyLevel;
        Console.WriteLine(difficultyLevel);
        Console.WriteLine(difficultyLevelInt);

        Console.WriteLine(OperacoesMatematicas.AdicionarInline(val1: 10, val2:5));
        (int resultadoAdicao, string nome) = OperacoesMatematicas.AdicionarMultipleReturn(val1: 5, val2: 5);
        Console.WriteLine(nome + " obteve o resultado de "+ resultadoAdicao);
        OperacoesMatematicas.optionalParams(10);

        var carro = new Carro("Corolla")
        {
            LancadoEm = new DateOnly(2015, 1, 1),
            Cor = Cor.Branco,
        };
        carro.Detalhes();
        

    }
}