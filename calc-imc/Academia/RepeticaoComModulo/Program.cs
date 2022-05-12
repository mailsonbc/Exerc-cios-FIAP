using System;

class Program
{
    public static void Main(string[] args)
    {
        int valor;
        int controle = 0;

        Console.WriteLine("Digite um valor: ");
        valor = Convert.ToInt32(Console.ReadLine());

        while(controle <= valor)
        {
            if((controle % 2) == 0)
            {
                Console.WriteLine("{0} é par!", controle);
            }
            else
            {
                Console.WriteLine("{0} é ímpar!", controle);
            }

            controle++;
        }
    }
}