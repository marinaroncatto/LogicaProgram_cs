namespace MultiplicacaoDedutiva;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Forma Dedutiva de Multiplicação");
        int resultadoIterativo = multIterativa(3, 2);
        Console.WriteLine("Iterativo: " + resultadoIterativo);
        int resultadoRecursivo = multRecursiva(3, 2);
        Console.WriteLine("Recursivo: "+resultadoRecursivo);
    }


    public static int multRecursiva(int m, int n)
    {
        if (n == 0)
        {
            return 0;
        }
        else
        {
            return m + multRecursiva(m, n - 1);
        }
    }


    public static int multIterativa(int m, int n)
    {
        int r = 0;
        for (int i = 1; i <= n; i++)
        {
            r += m;
        }
        return r;
    }
    
}
