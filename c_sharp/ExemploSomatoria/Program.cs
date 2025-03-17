namespace ExemploSomatoria;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Número: ");
        int numero = int.Parse(Console.ReadLine());
        int cont = 1;
        int soma = 0;

        while(cont <=numero){
            soma = soma + cont;
            cont = cont + 1;
        }
                             
        Console.WriteLine("Soma = {0}", soma);
    }
}
