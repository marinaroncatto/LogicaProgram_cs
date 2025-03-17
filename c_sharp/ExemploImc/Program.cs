namespace ExemploImc;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Peso: ");
        double peso = double.Parse(Console.ReadLine());

        Console.WriteLine("Altura: ");
        double altura = double.Parse(Console.ReadLine());

        double imc = peso / (altura * altura);

        Console.WriteLine("IMC = {0:N2}", imc);

        if(imc < 20){
            Console.WriteLine("Abaixo do peso");
        }else if(imc < 25){
            Console.WriteLine("Peso Ideal");
        }else{
            Console.WriteLine("Acima do peso.");
        }
    }
}
