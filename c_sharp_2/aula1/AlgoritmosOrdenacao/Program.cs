namespace AlgoritmosOrdenacao;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Algoritmos de Ordenação");
        //os mais rápidos são o Merge e o Quick sorte, 
        // os outros três se equivalem como mais lentos
    }

    //Bubble sort
    public static int[] ordenar(int items[])
    {
        int totalItems = items.Length;

        for (int i = 0; i < totalItems - 1; i++)
        {
            for (int j = 0; j < totalItems - i - 1; j++)
            {
                if (items[j] > items[j + 1])
                {
                    int temp = items[j];
                    items[j] = items[j + 1];
                    items[j + 1] = temp;
                }
            }
        }
        return items;
    }

    // insertion sort
    public void ordenar(int[] items)
    {
        int tamanho = items.Length;
        for (int posicao = 1; posicao < tamanho; posicao++)
        {
            int item = items[posicao];
            int anterior = posicao - 1;
            while (anterior >= 0 && items[anterior] > item)
            {
                items[anterior + 1] = items[anterior];
                anterior = anterior - 1;
            }
            items[anterior + 1] = item;
        }
    }

    //selection sort
    public static int[] ordenar(int items[])
    {
        int totalItems = items.Length;

        for (int i = 0; i < totalItems - 1; i++)
        {
            int posMenorItem = i;
            for (int j = i + 1; j < totalItems; j++)
            {
                if (items[j] < items[posMenorItem])
                    posMenorItem = j;
            }

            int temp = items[posMenorItem];
            items[posMenorItem] = items[i];
            items[i] = temp;
        }
        return items;
    }

    //Merge sort
    // Função principal que inicia o Merge Sort
    public static void MergeSort(int[] array)
    {
        if (array.Length <= 1)
            return;

        int mid = array.Length / 2;
        int[] left = new int[mid];
        int[] right = new int[array.Length - mid];

        // Divide o array em dois
        Array.Copy(array, 0, left, 0, mid);
        Array.Copy(array, mid, right, 0, array.Length - mid);

        // Recursivamente ordena os subarrays
        MergeSort(left);
        MergeSort(right);

        // Mescla os subarrays ordenados
        Merge(array, left, right);
    }

    // Função que mescla dois subarrays ordenados
    private static void Merge(int[] array, int[] left, int[] right)
    {
        int i = 0, j = 0, k = 0;

        // Mescla até que um dos subarrays termine
        while (i < left.Length && j < right.Length)
        {
            if (left[i] <= right[j])
                array[k++] = left[i++];
            else
                array[k++] = right[j++];
        }

        // Copia os elementos restantes de left, se houver
        while (i < left.Length)
            array[k++] = left[i++];

        // Copia os elementos restantes de right, se houver
        while (j < right.Length)
            array[k++] = right[j++];
    }

    //Quick sort
    private static void quicksort(int[] items, int inicio, int fim)
    {
        if (inicio < fim)
        {
            int pi = particionar(items, inicio, fim);
            quicksort(items, inicio, pi - 1);
            quicksort(items, pi + 1, fim);
        }
    }

    private static int particionar(int[] items, int inicio, int fim)
    {
        int pivot = items[fim];
        int i = (inicio - 1);

        for (int j = inicio; j <= fim; j++)
        {
            if (items[j] < pivot)
            {
                i++;
                trocar(items, i, j);
            }
        }
        trocar(items, i + 1, fim);
        return (i + 1);
    }

    private static void trocar(int[] items, int i, int j)
    {
        int temp = items[i];
        items[i] = items[j];
        items[j] = temp;
    }
    


}
