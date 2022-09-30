namespace DesafioPiramide;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um valor: ");
        int nivelUser = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("------------------------------------------- BY ALEC");
        
        //by Alec
        int cerca = 1;
        int contador;
        
        int linhas = nivelUser;
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
                cerca = cerca + 2;
                Console.WriteLine();
            }
        else
        {
            Console.WriteLine("As linhas devem estar maior que 3 e menor ou igual a 8!");
        }


        Console.WriteLine("------------------------------------------- BY PAULO");
        //by Paulo
        int n, a, c, l;

        
        n = nivelUser;
        c = n;
        l = n;
        string[,] nivel = new string[l, c];
        a = n - 1;

        if (n < 3 || n > 8)
        {
            Console.WriteLine("ERRO: Digite um valor entre 3 e 8");
        }
        else
        {

            for (int linha = 0; linha < n; linha++)
            {
                for (int coluna = 0; coluna < c; coluna++)
                {
                    if (coluna >= a)
                    {
                        Console.Write("#");

                    }
                    else
                    {
                        Console.Write(' ');
                    }

                }
                c++;
                a = a - 1;
                Console.WriteLine();
            }

        }
        Console.ReadLine();
    }
}
