using System;

class Program
{
    public static void Main(string[] args)
    {
        int escolha_jogador, escolha_computador, pontos_jogador = 0, pontos_computador = 0;
        string continua = "", escolha_computador_string = "", escolha_jogador_string = "";
        bool jogador = false, computador = false;
        var aleatorio = new Random();        
        

        while(continua != "n")
        {
            try
            {
                Console.WriteLine("*******************************");
                Console.WriteLine("*****       JOKENPO      ******");
                Console.WriteLine("*******************************");
                Console.WriteLine();

                Console.WriteLine("Qual a sua escolha? ");
                Console.WriteLine("[1] Pedra");
                Console.WriteLine("[2] Papel");
                Console.WriteLine("[3] Tesoura");

                escolha_jogador = Convert.ToInt32(Console.ReadLine());

                escolha_computador = aleatorio.Next(1, 3);

                switch (escolha_computador)
                {
                    case 1:
                        escolha_computador_string = "Pedra";
                        break;
                    case 2:
                        escolha_computador_string = "Papel";
                        break;
                    case 3:
                        escolha_computador_string = "Tesoura";
                        break ;
                }

                switch (escolha_jogador)
                {
                    case 1:
                        escolha_jogador_string = "Pedra";
                        break;
                    case 2:
                        escolha_jogador_string = "Papel";
                        break;
                    case 3:
                        escolha_jogador_string = "Tesoura";
                        break;
                }

                Console.WriteLine();

                if (escolha_computador == 1 && escolha_jogador == 3)
                {
                    computador = true;
                    jogador = false;
                    Console.WriteLine("Você perdeu!");
                }
                else if(escolha_computador == 2 && escolha_jogador == 1)
                {
                    computador = true;
                    jogador = false;
                    Console.WriteLine("Você perdeu!");
                }
                else if(escolha_computador == 3 && escolha_jogador == 2)
                {
                    computador = true;
                    jogador = false;
                    Console.WriteLine("Você perdeu!");
                }
                else if (escolha_computador == 3 && escolha_jogador == 1)
                {

                    jogador = true;
                    computador= false;
                    Console.WriteLine("Você ganhou!");
                }
                else if (escolha_computador == 1 && escolha_jogador == 2)
                {
                    jogador = true;
                    computador = false;
                    Console.WriteLine("Você ganhou!");
                }
                else if (escolha_computador == 2 && escolha_jogador == 3)
                {
                    jogador = true;
                    computador = false;
                    Console.WriteLine("Você ganhou!");
                }
                else if (escolha_computador == escolha_jogador)
                {
                    jogador = false;
                    computador = false;
                    Console.WriteLine("Empate!");
                }

                if(computador)
                {
                    pontos_computador++;
                }
                else if (jogador)
                {
                    pontos_jogador++;
                }

                Console.WriteLine();
                Console.WriteLine("Computador: " + escolha_computador_string + " X Jogador: " + escolha_jogador_string);
                Console.WriteLine();
                Console.WriteLine("Computador " + pontos_computador + " X " + pontos_jogador + " Jogador");
                Console.WriteLine();
            }
            catch (Exception)
            {
                Console.WriteLine("A escolha dever ser um número entre 1 ,2 e 3");
            }
            try
            {
                Console.WriteLine("Deseja continuar? Sim [ENTER], ou Não n ");
                continua = Console.ReadLine();
            }
            catch(Exception)
            {
                Console.WriteLine("Escolha entre ENTER e n");
            }

            Console.WriteLine();
            Console.WriteLine("Pontuação final: Computador {0} X Jogador {1}", pontos_computador, pontos_jogador);
        }
    }
}