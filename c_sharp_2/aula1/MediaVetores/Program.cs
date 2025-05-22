namespace MediaVetores;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-- PROGRAMA DA MÉDIA --");

        Console.WriteLine("Informe a quantidade de notas: ");
        int tam = Convert.ToInt32(Console.ReadLine());

        double[] notas = new double[tam];

        for (int cont = 0; cont < notas.Length; cont++)
        {
            Console.WriteLine("Informe a nota:");
            double nota = Double.Parse(Console.ReadLine());

            notas[cont] = nota;
        }

        double soma = 0;
        foreach (double item in notas)
        {
            soma = soma + item;
        }

        double media = soma / notas.Length;

        string situacao = "";
        if (media >= 6)
        {
            situacao = "Aprovado";
        }
        else
        {
            situacao = "Reprovado";
        }

        Console.WriteLine("Média: " + media);
        Console.WriteLine("Situação: " + situacao);
    }
}
