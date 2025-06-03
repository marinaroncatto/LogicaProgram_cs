namespace BuscaLinear;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Busca Linear em Vetores");

        int[] dados = { 52, 17, 69, 84, 3, 26, 83, 54, 19, 50 };
        int valor_procurado = 54;
        bool valor_encontrado = false;

        for (int i = 0; i < dados.Length; i++)
        {
            if (dados[i] == valor_procurado)
            {
                Console.WriteLine("Valor encontrado no índice " + i);
                valor_encontrado = true;
                break;
            }
        }
        if (!valor_encontrado)
        {
            Console.WriteLine("Valor não encontrado");
        }



    }
}
