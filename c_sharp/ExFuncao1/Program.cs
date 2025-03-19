namespace ExFuncao1;

class Program
{
    
    static void Main(string[] args)
    {
        Console.WriteLine("Informe seu nome: ");
        string umNome = Console.ReadLine();
        //chamar a função
        digaOla(umNome);
    }

    //procedimento - função que nao devolve resposta (void)

    // declaração da função
    static void digaOla(string nome){
        Console.WriteLine("Olá, {0}!", nome);
    }
}
