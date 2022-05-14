using System;

class Program
{
    public static void Main(string[] args)
    {
        int fatorial;

        Console.WriteLine("Digite o número para calcular o fatorial: ");
        fatorial = Convert.ToInt32(Console.ReadLine());
        int acumulador = 1;

        for (int i = 1; i <= fatorial; i++)
        {
            acumulador *= i;
        }
        Console.WriteLine();
        Console.WriteLine(acumulador);
    }
}