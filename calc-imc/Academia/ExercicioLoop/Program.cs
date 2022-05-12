using System;

class Program
{
    public static void Main(string[] args)
    {
        //Repetição de nome

        string? nome;
        int repeticao, controle = 0;

        Console.WriteLine("Digite o seu nome: ");
        nome = Console.ReadLine();

        Console.WriteLine("Quantas vezes você quer repetir? ");
        repeticao = Convert.ToInt32(Console.ReadLine());

        while (controle < repeticao)
        {
            Console.WriteLine(nome);
            controle++;
        }


        //Tabuada com while


        int x = 0, y = 0;

        while (x < 11)
        {
            while (y < 11)
            {
                Console.WriteLine("{0} x {1} = {2}", x, y, x * y);
                y++;
            }
            y = 0;
            x++;
            Console.WriteLine();
        }

        //Tabuada com for

        for (int i = 0; i < 11; i++)
        {
            for (int j = 0; j < 11; j++)
            {
                Console.WriteLine("{0} x {1} = {2}", i, j, i * j);
            }
            Console.WriteLine();
        }
    }
}