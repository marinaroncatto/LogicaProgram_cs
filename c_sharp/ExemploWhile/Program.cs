namespace ExemploWhile;

class Program
{
    static void Main(string[] args)
    {

        int soma = 0;        
        int num;

        Console.WriteLine("Digite um valor: ");
        num = int.Parse(Console.ReadLine());

        while(num >= 0){           
            soma = soma + num;
            Console.WriteLine("Digite um valor: ");
            num = int.Parse(Console.ReadLine());                            
        }
        Console.WriteLine("O total é: "+ soma);
        Console.WriteLine("fim");
    }
}
