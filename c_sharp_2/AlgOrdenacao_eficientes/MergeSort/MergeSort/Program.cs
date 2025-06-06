namespace MergeSort;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Merge Sort!");
        int[] vetor = { 5, 3, 1, 9, 7, 2, 4, 5, 8, 3 };

        merge(vetor, 0, vetor.Length - 1);

        //imprimir ordenado
        for (int i = 0; i < vetor.Length; i++)
            Console.WriteLine(vetor[i] + " ");
    }

    public static void merge(int[] vetor, int inicio, int fim)
    {
        int meio;
        if (inicio < fim)
        {
            meio = (inicio + fim) / 2;
            merge(vetor, inicio, meio);
            merge(vetor, meio + 1, fim);
            intercalar(vetor, inicio, fim, meio);
        }
    }

    public static void intercalar(int[] vetor, int inicio, int fim, int meio)
    {
        int[] vetor_aux = new int[vetor.Length];
        int inicio_vetor1 = inicio;
        int inicio_vetor2 = meio + 1;
        int pos_livre = inicio;

        while (inicio_vetor1 <= meio && inicio_vetor2 <= fim)
        {
            if (vetor[inicio_vetor1] <= vetor[inicio_vetor2])
            {
                vetor_aux[pos_livre] = vetor[inicio_vetor1];
                inicio_vetor1++;
            }
            else
            {
                vetor_aux[pos_livre] = vetor[inicio_vetor2];
                inicio_vetor2++;
            }
            pos_livre++;
        }

        //se ainda existem números no final do primeiro vetor que
        //não foram intercalados

        for (int i = inicio_vetor1; i <= meio; i++)
        {
            vetor_aux[pos_livre] = vetor[i];
            pos_livre++;
        }

        //se ainda existem números no final do segundo vetor que
        //não foram intercalados

        for (int i = inicio_vetor2; i <= fim; i++)
        {
            vetor_aux[pos_livre] = vetor[i];
            pos_livre++;
        }

        //substitui os valores ordenados do vetor_aux para o vetor
        for (int i = inicio; i <= fim; i++)
            vetor[i] = vetor_aux[i];

    }
}
