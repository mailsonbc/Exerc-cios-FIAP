using System;

class Program
{
    public static void Main(string[] args)
    {
        double[] vendas;
        double total = 0;
        int quantidadeVendedores;

        Console.WriteLine("Quantos vendedores? ");
        quantidadeVendedores = Convert.ToInt32(Console.ReadLine());
        vendas = new double[quantidadeVendedores];


        for(int i = 0; i < vendas.Length; i++)
        {
            Console.WriteLine("Digite o valor de vendas do vendedor {0}", i + 1);
            vendas[i] = Convert.ToDouble(Console.ReadLine());            
        }
        Console.WriteLine();

        for (int j = 0; j < vendas.Length; j++)
        {
            total += vendas[j];
            Console.WriteLine("Valor de vendas do vendedor {0}: {1}", j, vendas[j]);
        }
        Console.WriteLine();

        Console.WriteLine("Quantidade total de vendas: R${0}", total.ToString("0.00"));



    }
}