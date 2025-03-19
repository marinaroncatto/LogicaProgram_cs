namespace ExLacoIndefinido;

class Program
{
    static void Main(string[] args)
    {
        int soma = 0;

        Console.WriteLine("Número: ");
        int n = int.Parse(Console.ReadLine());

        while(n >=0){
            soma += n; // soma = soma + n
            Console.WriteLine("Número: ");
            n = int.Parse(Console.ReadLine());
        } 

        Console.WriteLine("Soma = {0}", soma);

        
    }
}
