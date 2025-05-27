namespace FuncaoRecursiva;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Função Recursiva");
        //função que chama a ela mesma
        ContarRegressivo(500);

        Console.WriteLine("Contar");
        Contar(10, 20);

    }

    static void Contar(int num, int limite)
    {
        if (num <= limite)
        {
            Console.WriteLine(num);
            Contar(num + 1, limite);
        }
    }

    static void ContarRegressivo(int num)
    {
        if (num >= 0)
        {
            Console.WriteLine(num);
            ContarRegressivo(num - 1);
        }
    }
}
