namespace Teste;

class Program{

        //programa para dizer o maior entre 10 números

public static void Main(string[] args){

        int maiorNumero = 0;

        for(int i = 0; i < 10; i++){
                Console.WriteLine("Digite um número: ");
                int numero = int.Parse(Console.ReadLine());

                if(maiorNumero < numero){
                        maiorNumero = numero;
                }

        }

        Console.WriteLine("Maior número: {0}", maiorNumero);

}

}