using Desafio_Piramide;
using Konsole;
using Spectre.Console;
using static System.Net.Mime.MediaTypeNames;

namespace DesafioPiramide;

internal class Program
{
    static void Main(string[] args)
    {
;

        AnsiConsole.Write(new Rule($"[yellow]Desafio do triângulo retângulo[/]").RuleStyle("grey").LeftJustified());

        AnsiConsole.MarkupLine("Digite um número entre [red]3[/] e [red]8[/]: ");
        int numeroLinhas = int.Parse(Console.ReadLine());


        if (numeroLinhas < 3 || numeroLinhas > 8)
        {
            Console.WriteLine("Número inválido. Digite um valor entre 3 e 8.");
            return;
        }
        Console.WriteLine();
        var qtdSustenido = CalcularQuantidadeTotal(numeroLinhas);
        var pbE = new ProgressBar(PbStyle.DoubleLine, qtdSustenido);


        var count = 0;
        for (int linha = 1; linha <= numeroLinhas; linha++)
        {
            for (int coluna = 1; coluna <= linha; coluna++)
            {
                AnsiConsole.Background = Color.FromInt32(count);
                AnsiConsole.Foreground = AnsiConsole.Background.GetInvertedColor();
                AnsiConsole.Write("#");
                count++;
                pbE.Refresh(count, "Alinhando a esquerda.");
                Thread.Sleep(200);
            }
            Console.WriteLine(); // Pula para a próxima linha
        }


        Console.WriteLine("\n===> Alinhado a Direita");
        var pbD = new ProgressBar(PbStyle.SingleLine, (qtdSustenido * 2));

        count = 0;
        for (int linha = 1; linha <= numeroLinhas; linha++)
        {
            // Espaços em branco para alinhar à direita
            for (int espacos = 0; espacos < numeroLinhas - linha; espacos++)
            {
                count++;
                pbD.Refresh(count, "Adicionando o espaço");
                Console.Write(" ");
                Thread.Sleep(100);
            }

            // Preenchimento com #
            for (int coluna = 1; coluna <= linha; coluna++)
            {
                count++;
                pbD.Refresh(count, "Adicionando o '#'");
                AnsiConsole.Write("#");
                Thread.Sleep(100);
            }
            count++;
            Console.WriteLine(); // Pula para a próxima linha
        }
        pbD.Refresh((qtdSustenido * 2), "Alinhado a Direita");

        //AnsiConsole.Write(new ColorBox(width: 80, height: 2));
        Console.ReadLine();
    }


    static int CalcularQuantidadeTotal(int numeroLinhas)
    {
        //n * (n + 1) / 2
        return (numeroLinhas * (numeroLinhas + 1)) / 2;
    }

}
