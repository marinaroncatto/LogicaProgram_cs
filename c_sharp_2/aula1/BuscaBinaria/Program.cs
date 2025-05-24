namespace BuscaBinaria;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Busca binária");

    }

    public static int BuscaBinaria(int[] elementos, int valor)
    {
        int inicio = 0;
        int fim = elementos.Lenght - 1;

        while (inicio <= fim)
        {
            int meio = inicio + (fim - inicio) / 2;

            //verifica se está no meio
            if (elementos[meio] == valor)
                return meio;

            //Se maior, ignora o lado esquerdo
            if (elementos[meio] < valor)
                inicio = meio + 1;

            //Se menor, ignora o lado direito
            else
                fim = meio - 1;
        }
        //se não encontra, retorna -1;
        return -1;
    }
}
