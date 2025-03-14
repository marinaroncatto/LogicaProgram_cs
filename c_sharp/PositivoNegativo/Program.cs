namespace PositivoNegativo;

class Program
{
    static void Main(string[] args)
    {
        int num;

        Console.WriteLine("Digite um número: ");
        num = int.Parse(Console.ReadLine());
        
        if(num >= 0){
            Console.WriteLine("Número positivo");
        }else{
            Console.WriteLine("Número negativo");
        }
       
    }
}
