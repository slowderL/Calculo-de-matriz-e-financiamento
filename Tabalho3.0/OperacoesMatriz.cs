using System;
public class OperacoesMatriz
{
    public static void Executar()
    {
        Console.WriteLine("\nOperações com Matriz Quadrada");

        Console.Write("Informe o tamanho da matriz quadrada (N): ");
        int N = Convert.ToInt32(Console.ReadLine());

        int[,] matriz = GerarMatriz(N);

        Console.WriteLine("\nMatriz gerada:");
        ApresentarMatriz(matriz);

        Console.WriteLine("\nDiagonal principal:");
        ApresentarDiagonalPrincipal(matriz);

        Console.WriteLine("\nDiagonal secundária:");
        ApresentarDiagonalSecundaria(matriz);

        double determinante = CalcularDeterminante(matriz);
        Console.WriteLine($"\nDeterminante da matriz: {determinante:F2}");
    }

    public static int[,] GerarMatriz(int N)
    {
        Random rand = new Random();
        int[,] matriz = new int[N, N];

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                matriz[i, j] = rand.Next(1, 10);
            }
        }

        return matriz;
    }

    public static void ApresentarMatriz(int[,] matriz)
    {
        int N = matriz.GetLength(0);
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    public static void ApresentarDiagonalPrincipal(int[,] matriz)
    {
        int N = matriz.GetLength(0);
        for (int i = 0; i < N; i++)
        {
            Console.Write(matriz[i, i] + " ");
        }
        Console.WriteLine();
    }

    public static void ApresentarDiagonalSecundaria(int[,] matriz)
    {
        int N = matriz.GetLength(0);
        for (int i = 0; i < N; i++)
        {
            Console.Write(matriz[i, N - i - 1] + " ");
        }
        Console.WriteLine();
    }

    public static double CalcularDeterminante(int[,] matriz)
    {
        int N = matriz.GetLength(0);

        if (N == 1)
        {
            return matriz[0, 0];
        }
        else if (N == 2)
        {
            return matriz[0, 0] * matriz[1, 1] - matriz[0, 1] * matriz[1, 0];
        }
        else
        {
            double determinante = 0;

            for (int j = 0; j < N; j++)
            {
                determinante += matriz[0, j] * Cofator(matriz, 0, j);
            }

            return determinante;
        }
    }

    public static double Cofator(int[,] matriz, int linha, int coluna)
    {
        int N = matriz.GetLength(0);
        int[,] submatriz = new int[N - 1, N - 1];
        int subI = 0, subJ = 0;

        for (int i = 0; i < N; i++)
        {
            if (i == linha) continue;
            subJ = 0;

            for (int j = 0; j < N; j++)
            {
                if (j == coluna) continue;
                submatriz[subI, subJ] = matriz[i, j];
                subJ++;
            }
            subI++;
        }

        return Math.Pow(-1, linha + coluna) * CalcularDeterminante(submatriz);
    }
}