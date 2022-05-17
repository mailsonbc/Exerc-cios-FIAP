using System;

class Program
{
    public static void Main(string[]_0)
    {
        double[,] boletim = new double[5, 4];

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Digite o ID do aluno:");
            boletim[i, 0] = Convert.ToDouble(Console.ReadLine());
            for (int j = 0; j < 4; j++)
            {                
                Console.WriteLine("Digite a nota do {0}° bimestre", j + 1);
                boletim[i, j] = Convert.ToDouble(Console.ReadLine());
            }
        }

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.WriteLine("[ID do aluno {0}, Bimestre {1}] = Nota [{2}]", i + 1, j + 1, boletim[i, j]);
            }
        }
    }
}