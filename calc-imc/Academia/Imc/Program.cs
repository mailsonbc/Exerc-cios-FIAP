class Program
{
    static void Main(string[] args)
    {
        double peso;
        double altura;
        double imc;
        string nome;
        string situacao = "Você está magro(a)!";

        Console.WriteLine("Digite o seu nome: ");
        nome = Console.ReadLine();
        
        Console.WriteLine("Digite o seu peso: ");
        peso = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite a sua altura: ");
        altura = Convert.ToDouble(Console.ReadLine());

        //imc = peso / (altura * altura);

        imc = peso / Math.Pow(altura, 2);

        if (imc > 30)
        {
            situacao = "Você está gordo(a)!";
        }

        Console.WriteLine("==========================");
        Console.WriteLine("{0}, seu IMC é : {1}", nome, imc.ToString("#0.00"));
        Console.WriteLine(situacao);

        Console.ReadLine();
    }
}