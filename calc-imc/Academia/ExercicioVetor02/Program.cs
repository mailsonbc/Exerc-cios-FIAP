using System;

class Program
{
    public static void Main(string[] args)
    {
        int[] matrizA = new int[5];
        int[] matrizB = new int[5];
        int[] matrizC = new int[5];

        Console.WriteLine("Digite 5 valores inteiros para a Matriz A:");
        for (int i = 0; i < matrizA.Length; i++)
        {
            Console.WriteLine("Digite valor {0} ", i + 1);
            matrizA[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine();

        Console.WriteLine("Digite 5 valores inteiros para a Matriz B:");
        for (int j = 0; j < matrizB.Length; j++)
        {
            Console.WriteLine("Digite valor {0} ", j + 1);
            matrizB[j] = Convert.ToInt32(Console.ReadLine());
        }

        for (int x = 0; x < matrizC.Length; x++)
        {
            matrizC[x] = matrizA[x] * matrizB[x];
        }

        Console.WriteLine();

        for (int y = 0; y < matrizC.Length; y++)
        {
            Console.WriteLine("Matriz A: {0} x {1} Matriz B = Matriz C: {2}", matrizA[y], matrizB[y], matrizC[y]);
        }
    }
}