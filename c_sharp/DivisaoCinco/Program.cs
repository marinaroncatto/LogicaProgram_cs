namespace DivisaoCinco;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Números divisíveis por 5");
         for(int i = 0; i <=80; i++){
            
            if(i % 5 == 0){
                Console.WriteLine("Valor "+i);
            }
            
        }
    }
}
