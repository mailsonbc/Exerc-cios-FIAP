using System;

class Program
{
    public static void Main(string[] args)
    {
        double nota1;
        double nota2;
        double nota3;
        double media;

        try
        {
            Console.WriteLine("Digite a primeira nota: ");
            nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota: ");
            nota2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota: ");
            nota3 = Convert.ToDouble(Console.ReadLine());

            media = (nota1 + nota2 + nota3) / 3;


            Console.WriteLine("A média do aluno é: {0}", media.ToString("#0.00"));
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
            throw;
        }

       
    }
}