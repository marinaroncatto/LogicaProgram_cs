namespace ExFuncao2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Primeiro Valor: ");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Segundo Valor: ");
        int b = int.Parse(Console.ReadLine());

        int m = maior(a, b);
        Console.WriteLine("Maior: {0}", m);
    }

    static int maior(int n1, int n2){
        int maior;
        if(n1 >= n2){
            maior = n1;
        }else{
            maior = n2;
        }
        return maior;
    }
}
