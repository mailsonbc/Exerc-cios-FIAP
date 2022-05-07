class Program
{
    static void Main(string[] args)
    {
        //TODO: Mostar a classificação do imc

        double peso;
        double altura;
        double imc;
        string nome;
        

        Console.WriteLine("Digite o seu nome: ");
        nome = Console.ReadLine();
        
        Console.WriteLine("Digite o seu peso: ");
        peso = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite a sua altura: ");
        altura = Convert.ToDouble(Console.ReadLine());


        imc = peso / Math.Pow(altura, 2);

        

        Console.WriteLine("==========================");
        Console.WriteLine("{0}, seu IMC é : {1}", nome, imc.ToString("#0.00"));
        

        Console.ReadLine();
    }
}