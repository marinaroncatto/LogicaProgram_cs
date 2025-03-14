namespace AreaCirculo;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Raio: ");
        double raio = double.Parse(Console.ReadLine());

        double area = 3.14159 * (raio * raio);

        Console.WriteLine("Area: {0:N2}", area); // formata a saída com 2 casas decimais

        
    }
}
