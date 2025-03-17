namespace ExemploVeiculo;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Velocidade: ");
        int velocidade = int.Parse(Console.ReadLine());

        if(velocidade > 70){
            Console.WriteLine("Multado");
        }else{
            Console.WriteLine("Não Multado");
        }

        Console.WriteLine("Fim");
        
    }
}
