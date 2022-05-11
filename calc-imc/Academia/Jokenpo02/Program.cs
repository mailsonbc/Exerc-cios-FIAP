using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("JOKENPO-02");
        Console.WriteLine();

        int escolhaJogador, escolhaComputador;
        var aleatorio = new Random();
        string escolhaComputadorString = "";

        while (true)
        {
            escolhaComputador = aleatorio.Next(1, 4);

            switch (escolhaComputador)
            {
                case 1:
                    escolhaComputadorString = "PEDRA";
                    break;
                case 2:
                    escolhaComputadorString = "PAPEL";
                    break;
                case 3:
                    escolhaComputadorString = "TESOURA";
                    break;
                default:
                    Console.WriteLine("Escolha inválida!");
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("[1] PEDRA");
            Console.WriteLine("[2] PAPEL");
            Console.WriteLine("[3] TESOURA");
            Console.WriteLine();

            escolhaJogador = Convert.ToInt32(Console.ReadLine());

            switch (escolhaJogador)
            {
                case 1:
                    Console.WriteLine("O jogador escolheu PEDRA!");
                    Console.WriteLine("O computador escolheu: {0}!", escolhaComputadorString);
                    switch (escolhaComputador)
                    {
                        case 1:
                            Console.WriteLine("Empate!");
                            break;
                        case 2:
                            Console.WriteLine("O computador ganhou!");
                            break;
                        case 3:
                            Console.WriteLine("Você ganhou!");
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("O jogador escolheu PAPEL!");
                    Console.WriteLine("O computador escolheu: {0}!", escolhaComputadorString);
                    switch (escolhaComputador)
                    {
                        case 1:
                            Console.WriteLine("Você ganhou!");
                            break;
                        case 2:
                            Console.WriteLine("Empate!");
                            break;
                        case 3:
                            Console.WriteLine("O computador ganhou!");
                            break;
                    }
                    break;
                case 3:
                    Console.WriteLine("O jogador escolheu TESOURA!");
                    Console.WriteLine("O computador escolheu: {0}!", escolhaComputadorString);
                    switch (escolhaComputador)
                    {
                        case 1:
                            Console.WriteLine("O computador ganhou!");
                            break;
                        case 2:
                            Console.WriteLine("Você ganhou!");
                            break;
                        case 3:
                            Console.WriteLine("Empate!");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Escolha inválida!");
                    break;
            }
        }
    }
}