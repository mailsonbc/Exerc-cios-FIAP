using System;

class Program
{
    public static void Main(string[] args)
    {
        int[,] matriz = new int[3,3];

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine("Preencha a matriz: ");
                matriz[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine();

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine("[{0}, {1}] = [{2}]",i, j, matriz[i, j]);
            }
        }
    }
}