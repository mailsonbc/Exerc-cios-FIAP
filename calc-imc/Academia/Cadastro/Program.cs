using System;

class Program
{
    public static void Main(string[] _0)
    {
        string?[,] cadastro = new string[5, 4];
        string? continua = "";
        string campo = "";
        

        Console.WriteLine("=================================");
        Console.WriteLine("|     CADASTRO DE CONTATOS      |");
        Console.WriteLine("=================================");

        while (continua != "n")
        {
            for (int linha = 0; linha < 5; linha++)
            {
                for (int coluna = 0; coluna < 4; coluna++)
                {
                    switch (coluna)
                    {
                        case 0:
                            campo = "CPF";
                            break;
                        case 1:
                            campo = "Nome";
                            break;
                        case 2:
                            campo = "Telefone";
                            break;
                        case 3:
                            campo = "e-mail";
                            break;
                    }
                    Console.Write("Digite o {0}: ", campo);
                    cadastro[linha, coluna] = Console.ReadLine();                    
                }

                Console.WriteLine();
                Console.WriteLine("Cadastrar outro contato? (S/N)");
                continua = Console.ReadLine();
                if (continua == "n")
                {
                    linha = 5;
                }
            }

            for (int linha = 0; linha < cadastro.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < cadastro.GetLength(1); coluna++)
                {
                    Console.WriteLine("Contato {0}: {1}", linha + 1, cadastro[linha, coluna]);
                    Console.WriteLine();                    
                }
            }
        }
    }
}