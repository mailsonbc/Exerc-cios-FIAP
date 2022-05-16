using System;

class Program
{
    public static void Main(string[] args)
    {
        int[] par = new int[15];
        int[] impar = new int[15];
        int[] geral = new int[15];
        int x, ultimoIndicePar = 0, ultimoIndiceImpar = 0;

        Console.WriteLine("Digite 15 valores inteiros: ");
        for (int i = 1; i < geral.Length; i++)
        {
            Console.WriteLine("Digite o valor {0}: ", i);
            x = Convert.ToInt32(Console.ReadLine());
            if((x % 2) == 0)
            {
                par[ultimoIndicePar] = x;
                geral[i] = x;
                ultimoIndicePar++;
            }
            else
            {
                impar[ultimoIndiceImpar] = x;
                geral[i] = x;
                ultimoIndiceImpar++;
            }
        }

        for (int j = 0; j < geral.Length; j++)
        {
            Console.WriteLine();
            Console.WriteLine("Números pares {0}, Números ímpares {1}, Todos os números {2}", par[j], impar[j], geral[j]);            
            Console.WriteLine();
        }
    }
}