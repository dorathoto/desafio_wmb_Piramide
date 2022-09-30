namespace DesafioPiramide;

internal class Program
{
    static void Main(string[] args)
    {


        Console.WriteLine("Digite quantos níveis vai ter o seu triângulo");
        var nivelUser = Convert.ToInt32(Console.ReadLine());


        //By Alec
        int linhas = nivelUser;
        int cerca = 1;
        int contador;
        contador = linhas;

        if (contador > 3 && contador <= 8)
            for (int i = 0; i < contador; i++)
            {
                for (int j = 1; j <= linhas; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= cerca; k++)
                {
                    Console.Write("#");
                }

                linhas--;
                cerca++;
                Console.WriteLine();
            }
        else
        {
            Console.WriteLine("As linhas devem estar maior que 3 e menor ou igual a 8!");
        }


        //By Paulo

        int n, a;
        n = nivelUser;
        string[,] nivel = new string[n, n];
        a = n - 1;

        if (n < 3 || n > 8)
        {
            Console.WriteLine("ERRO: Digite um valor entre 3 e 8");
        }
        else
        {

            for (int l = 0; l < n; l++)
            {
                for (int c = 0; c < n; c++)
                {
                    if (c >= a)
                    {
                        Console.Write("#");

                    }
                    else
                    {
                        Console.Write(' ');
                    }

                }
                a = a - 1;
                Console.WriteLine();
            }

        }


        Console.ReadLine();
    }
}
