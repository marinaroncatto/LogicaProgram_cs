namespace Autenticacao;

class Program
{
    static void Main(string[] args)
    {

        String nome, senha;

        Console.WriteLine("Digite o nome do usuário: ");
        nome = Console.ReadLine();

        Console.WriteLine("Digite a senha: ");
        senha = Console.ReadLine();

        if(nome == "Maria" && senha == "123ca"){
            Console.WriteLine("Acesso Liberado");
            for(int i = 0; i<=10; i++){
                if(i % 2 == 0){
                    Console.WriteLine("Valor: "+i);
                }
            }
        }else{
            Console.WriteLine("Acesso negado");
        }    
    }
}
