namespace SelectionSort;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Selection Sort");

        int[] vetor = { 99, 82, 50, 67, 90, 20, 71, 8, 21, 18 };
        int min, temp;
        ImprimirVetor(vetor);
        for (int i = 0; i < vetor.Length; i++)
        {
            min = i;
            for (int pos = (i + 1); pos < vetor.Length; pos++)
            {
                if (vetor[pos] < vetor[min])
                {
                    min = pos;
                }
            }
            if (vetor[i] != vetor[min])
            {
                temp = vetor[i];
                vetor[i] = vetor[min];
                vetor[min] = temp;
            }
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
