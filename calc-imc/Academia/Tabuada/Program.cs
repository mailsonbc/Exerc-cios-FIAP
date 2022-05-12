using System;

class Program
{
    public static void Main(string[] args)
    {
        int fator01, fator02 = 0;

        Console.WriteLine("Qual a tabuada? ");
        fator01 = Convert.ToInt32(Console.ReadLine());

        while (fator02 <= 10)
        {
            Console.WriteLine("{0} x {1} = {2}", fator01, fator02, fator01 * fator02);

            fator02++;
        }

        //for(fator02 = 0; fator02 <= 10; fator02++)
        //{
        //    Console.WriteLine("{0} x {1} = {2}", fator01, fator02, fator01 * fator02);
        //}
    }
}