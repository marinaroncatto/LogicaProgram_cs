namespace BubbleSort;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bubble Sort");

        int[] vetor = { 99, 82, 50, 67, 90, 20, 71, 8, 21, 18 };
        bool mudou = true; //1a otimização
        int ultimo = vetor.Length - 1; // 2a otimização
        int ultimo_temp = vetor.Length - 1;

        ImprimirVetor(vetor);

        while (mudou)
        {
            int pos = 0;
            mudou = false;
            int temp = 0;

            while (pos < ultimo)
            {
                if (vetor[pos] > vetor[pos + 1])
                {
                    temp = vetor[pos];          //
                    vetor[pos] = vetor[pos + 1];// troca
                    vetor[pos + 1] = temp;      //
                    mudou = true;
                    ultimo_temp = pos;
                }
                pos++;
            }
            ultimo = ultimo_temp;
        }

        ImprimirVetor(vetor);

    }

    public static void ImprimirVetor(int[] vetor)
    {
        Console.WriteLine("\nImprimindo Vetor!\n");    
        foreach (var numero in vetor)
        {
            Console.WriteLine(numero);
        }
    }

}
