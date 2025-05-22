namespace Vetores;

class Program
{
    static void Main(string[] args)
    {
        //criar vetores com valores iniciais
        int[] A = { 15, 10, 3 };


        //criar vetores com uma qtd de compartimentos
        int qtd = 3;
        int[] B = new int[qtd];

        //altera valores das posições
        int pos = 0;
        B[pos] = 10;
        B[1] = 7;
        B[2] = 8;

        //lê os valores das posições
        int pos1 = 0;
        int valor1 = B[pos1];
        int valor2 = B[1];

        Console.WriteLine(valor1);

        //tamanho do vetor
        int tam = B.Length;

        Console.WriteLine(tam);

        //iterar sobre o vetor usando o FOR
        for (int cont = 0; cont < B.Length; cont++)
        {
            int item = B[cont];
            Console.WriteLine(item);
        }

        //iterar sobre o vetor usando FOREACH
        foreach (int item in B)
        {
            Console.WriteLine(item);
        }

    }
}
