namespace EstruturasDeRepeticao;

class Program
{
    static void Main(string[] args)
    {
        int controle = 0;

        while(controle < 10){

            Console.WriteLine("Bom dia!");
            controle = controle + 1;
        }
        
        for(int i = 0; i < 10; i++){
            Console.WriteLine("Bom tarde!");
        }
    }
}
