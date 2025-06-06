namespace QuickSort;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Quick Sort!");
        int[] vetor = { 5, 3, 1, 9, 7, 2, 4, 5, 8, 3 };

        quick(vetor, 0, vetor.Length - 1);

        //imprimir valores ordenados
        for (int i = 0; i < vetor.Length; i++)
            Console.Write(vetor[i] + " ");
    }

    public static void quick(int[] vetor, int inicio, int fim)
    {
        if (inicio < fim)
        {
            int pivo = particionar(vetor, inicio, fim);
            quick(vetor, inicio, pivo - 1);
            quick(vetor, pivo + 1, fim);
        }
    }

    public static int particionar(int[] vetor, int inicio, int fim)
    {
        int esq = inicio;
        int dir = fim;
        int pivo = vetor[inicio];

        while (esq < dir)
        {
            while (esq <= fim && vetor[esq] <= pivo)
            {
                esq++;
            }
            while (dir >= 0 && vetor[dir] > pivo)
            {
                dir--;
            }

            if (esq < dir)
            {
                int aux = vetor[esq];
                vetor[esq] = vetor[dir];
                vetor[dir] = aux;
            }
        }
        vetor[inicio] = vetor[dir];
        vetor[dir] = pivo;
        return dir;
    }

}
