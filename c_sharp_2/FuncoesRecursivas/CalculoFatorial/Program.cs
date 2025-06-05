namespace CalculoFatorial;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Calculo Fatorial com Recursividade");
        int respostaIterativa = fatIterativo(3);
        Console.WriteLine("Fatorial Iterativo: "+respostaIterativa);
        int respostaRecursiva = fatRecursivo(3);
        Console.WriteLine("Fatorial Recursivo: "+respostaRecursiva);
    }


    public static int fatRecursivo(int numero)
    {
        if (numero == 1 || numero == 0)
            return 1;
        else
            return numero * fatRecursivo(numero - 1);
    }

    public static int fatIterativo(int numero)
    {
        int resultado = 1;
        while (numero >= 1)
        {
            resultado = resultado * numero;
            numero = numero - 1;
        }
        return resultado;
    }
}
