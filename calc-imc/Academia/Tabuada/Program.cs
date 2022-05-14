using System;

class Program
{
    public static void Main(string[] args)
    {
        int fator01, fator02;
        string? continua = "";

        while ((continua != "n") && (continua != "N"))
        {
            Console.WriteLine("Qual a tabuada? ");
            fator01 = Convert.ToInt32(Console.ReadLine());
            fator02 = 0;

            while (fator02 <= 10)
            {
                int resultado = fator01 * fator02;

                Console.WriteLine("{0} x {1} = {2}", fator01, fator02, resultado);

                fator02++;
            }

            //for (fator02 = 0; fator02 <= 10; fator02++)
            //{
            //    int resultado = fator01 * fator02;
            //    Console.WriteLine("{0} x {1} = {2}", fator01, fator02, resultado);
            //}

            Console.WriteLine("Calcular outra tabuada? Sim 's' | Não 'n'");
            continua = Console.ReadLine();             
        }
    }
}