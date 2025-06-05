namespace Fibonacci;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Números de Fibonacci");
        int NumfibIterativo = fibIterativo(10);
        Console.WriteLine("Interatibo: " + NumfibIterativo);
        int NumFibRecursivo = fibRecursivo(1, 1, 10);
        Console.WriteLine("Recursivo: "+NumFibRecursivo);

    }

    public static int fibRecursivo(int numero1, int numero2, int numeroSequencia)
    {
        if (numeroSequencia > 1)
           return fibRecursivo(numero2, numero1 + numero2, --numeroSequencia);
        
        else
           return numero1;
        
    }

    public static int fibIterativo(int numero)
    {
        int num1 = 1;
        int num2 = 1;
        int proxNum = 0;
        for (int i = 3; i <= numero; i++)
        {
            proxNum = num1 + num2;
            num1 = num2;
            num2 = proxNum;
        }
        return proxNum;
    }
}
