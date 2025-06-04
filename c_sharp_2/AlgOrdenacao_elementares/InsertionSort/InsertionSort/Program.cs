namespace InsertionSort;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Insertion Sort");
        int[] vetor = { 99, 82, 50, 67, 90, 20, 71, 8, 21, 18 };
        int num, pos_verificada;
        ImprimirVetor(vetor);

        for (int pos = 1; pos < vetor.Length; pos++)
        {
            num = vetor[pos];
            pos_verificada = pos - 1;
            while (pos_verificada >= 0 && num < vetor[pos_verificada])
            {
                vetor[pos_verificada + 1] = vetor[pos_verificada];
                pos_verificada--;
            }
            vetor[pos_verificada + 1] = num;
        }
        ImprimirVetor(vetor);
    }

    public static void ImprimirVetor(int[] vetor)
    {
        Console.WriteLine("\nImprimindo Vetor\n");
        foreach (var numero in vetor)
        {
            Console.WriteLine(numero);            
        }
    }

}
