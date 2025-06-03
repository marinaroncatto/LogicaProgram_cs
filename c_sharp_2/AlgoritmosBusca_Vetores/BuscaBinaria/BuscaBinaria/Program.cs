namespace BuscaBinaria;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Busca Binária em Vetores");

        int[] dados = { 3, 17, 19, 26, 50, 52, 54, 69, 83, 84 };
        int valor_procurado = 54;
        bool valor_encontrado = false;

        int inicio = 0;
        int fim = dados.Length - 1;
        int meio;

        do
        {
            meio = inicio + (fim - inicio) / 2;
            if (dados[meio] == valor_procurado)
            {
                Console.WriteLine("Valor encontrado no índice " + meio);
                valor_encontrado = true;
                break;
            }
            else if (dados[meio] > valor_procurado)
            {
                fim = meio - 1;
            }
            else
            {
                inicio = meio + 1;
            }
        } while (inicio <= fim);

        if (!valor_encontrado)
        {
            Console.WriteLine("Valor não encontrado");
        }

    }
}
