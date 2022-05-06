using System;

class Program
{
    public static void Main(string[] args)
    {
        Double nota1, nota2, media;
        string situação = "Sua média foi maior ou igual a 70: APROVADO";


        Console.WriteLine("Situação Aluno");
        Console.WriteLine("==============================");

        Console.WriteLine("Digite a primeira nota: ");
        nota1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite a primeira nota: ");
        nota2 = Convert.ToDouble(Console.ReadLine());

        media = (nota1 + nota2) / 2;

        Console.WriteLine("Média: {0}", media);
        

        if (media < 70)
        {
            situação = "Sua média foi menor que 70: REPROVADO";
        }

        Console.WriteLine(situação);

        //if(media >= 70)
        //{
        //    Console.WriteLine("Sua média foi maior ou igual a 70: APROVADO");
        //}
        //else
        //{
        //    Console.WriteLine("Sua média foi menor que 70: REPROVADO");
        //}

        Console.ReadKey();
    }
}