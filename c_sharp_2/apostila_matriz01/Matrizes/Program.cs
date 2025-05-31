namespace Matrizes;

class Program
{
    static void Main(string[] args)
    {
        //decalarando uma matriz
        double[,] notas = { {8.7, 5.4, 6.2},
                            {3.8, 2.7, 8.5},
                            {9.1, 0.9, 4.2},
                            {7.1, 1.8, 8.8} };

        //alterando o valor de uma posição
        notas[0, 1] = 6.4; //linha zero, coluna 1

        //utilizando variavel                            
        double nota_antonio = notas[3, 2];
        Console.WriteLine(nota_antonio);

        //declarando matriz vazia
        double[,] notas2 = new double[4, 3]; //quatro linhas e 3 colunas
        

    }
}
