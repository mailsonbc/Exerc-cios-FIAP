using System;

class Program
{
    public static void Main(string[] args)
    {
        Double nota1, nota2, media, frequencia, quantidade_aulas, quantidade_faltas;

        Console.WriteLine("Situação Final do Aluno");
        Console.WriteLine("=======================");

        Console.WriteLine("Entre com a primeira nota: ");
        nota1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Entre com a segunda nota: ");
        nota2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite a quantidade de aulas: ");
        quantidade_aulas = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite a quantidade de faltas: ");
        quantidade_faltas = Convert.ToDouble(Console.ReadLine());

        media = (nota1 + nota2) / 2;

        //frequencia = 100 - ((quantidade_faltas / 100) * quantidade_aulas);
        frequencia = 100 - ((quantidade_faltas / quantidade_aulas) * 100);

        if((media >= 70) && (frequencia >= 75))
        {
            Console.WriteLine("APROVADO");
        }
        else
        {
            Console.WriteLine("REPROVADO");
        }

        Console.WriteLine(media);
        Console.WriteLine(frequencia);


    }
}