class Program
{
    static void Main(string[] args)
    {
        double peso;
        double altura;
        double imc;
        
        Console.WriteLine("Digite o seu peso: ");
        peso = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite a sua altura: ");
        altura = Convert.ToDouble(Console.ReadLine());


        imc = peso / Math.Pow(altura, 2);
        Console.WriteLine("==========================");


        if (imc <= 18.5)
        {            
            Console.WriteLine("Seu IMC é : {0}", imc.ToString("#0.00"));
            Console.WriteLine("Você está abaixao do peso!");
        }else if((imc >= 18.6) && (imc <= 24.9))
        {        
            Console.WriteLine("Seu IMC é : {0}", imc.ToString("#0.00"));
            Console.WriteLine("Você está com o peso ideal (parabéns)!");
        }else if((imc >= 25) && (imc <= 29.9))
        {            
            Console.WriteLine("Seu IMC é : {0}", imc.ToString("#0.00"));
            Console.WriteLine("Você está levemente acima do peso!");
        }else if((imc >= 30) && (imc <= 34.9))
        {            
            Console.WriteLine("Seu IMC é : {0}", imc.ToString("#0.00"));
            Console.WriteLine("Você está com obesidade grau I!");
        }else if((imc >= 35) && (imc <= 39.9))
        {            
            Console.WriteLine("Seu IMC é : {0}", imc.ToString("#0.00"));
            Console.WriteLine("Você está com obesidade grau II (severa)!");
        }else if(imc >= 40)
        {           
            Console.WriteLine("Seu IMC é : {0}", imc.ToString("#0.00"));
            Console.WriteLine("Você está com obesidade grau III (móbida)!");
        }

        

        Console.WriteLine("==========================");
        

        Console.ReadLine();
    }
}