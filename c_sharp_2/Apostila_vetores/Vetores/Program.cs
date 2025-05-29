namespace Vetores;

class Program
{
    static void Main(string[] args)
    {
        //declaração de vetor
        double[] notas = { 8.7, 5.4, 6.2 };

        //atribuindo novos valores
        notas[1] = 6.4;

        //acessando uma nota
        double nota_jose = notas[1];
        Console.WriteLine(nota_jose);

        //criando vetor vazio
        double[] notas2 = new double[3];
        //vetor de 3 espaços

        //declarando vetor sem especificar tamanho
        double[] notas3;
        int tamanho_vetor = int.Parse(Console.ReadLine());
        notas = new double[tamanho_vetor];
    }
}
