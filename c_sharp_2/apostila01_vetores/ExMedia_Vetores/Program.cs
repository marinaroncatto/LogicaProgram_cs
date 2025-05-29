namespace ExMedia_Vetores;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Defina quantos alunos há na turma: ");
        int tamanho = int.Parse(Console.ReadLine());

        double[] notas = new double[tamanho];

        //armazenando as notas
        for (int i = 0; i < notas.Length; i++)
        {
            Console.WriteLine("Digite a nota do aluno " + (i + 1) + ":");
            notas[i] = Convert.ToDouble(Console.ReadLine());
        }

        //recurando notas para calcular a média
        double media = calcularMedia(notas);

        Console.WriteLine($"Média das notas da turma é: {media}");
    }//main

    static double calcularMedia(double[] notas)
    {
        double soma = 0;
        for (int i = 0; i < notas.Length; i++)
        {
            Console.WriteLine("Nota do aluno " + (i + 1) + ": " + notas[i]);
            soma += notas[i];
        }
        return soma / notas.Length;
        
    }
}
