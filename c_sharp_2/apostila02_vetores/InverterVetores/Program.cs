using System.Net.Mail;

namespace InverterVetores;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Cópia e Inversão de Vetores");

        string[] nomes = { "Ana", "Maria", "Braga" };
        string[] copia = copiarVetor(nomes);
        InverterVetores(copia);

        Console.WriteLine("Vetor original: ");
        imprimirVetor(nomes);

        Console.WriteLine("Cópia do Vetor invertido: ");
        imprimirVetor(copia);

    }

    static void imprimirVetor(string[] vetor)
    {
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.WriteLine(vetor[i]);  
        }
    }

    static void InverterVetores(string[] copia)
    {
        string temp;
        for (int i = 0; i < copia.Length/2; i++)
        {
            temp = copia[i];
            copia[i] = copia[copia.Length - 1 - i];
            copia[copia.Length - 1 - i] = temp;
        }
    }

    static string[] copiarVetor(string[] nomes)
    {
        string[] copia = new string[nomes.Length];
        for (int i = 0; i < nomes.Length; i++)
        {
            copia[i] = nomes[i];
        }
        return copia;
    }
}
