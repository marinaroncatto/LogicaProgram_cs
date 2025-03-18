namespace EstudoDeFuncao;

class Program
{

    // nosssa função
    public int multiplicar(int x, int y){
        int total;
        total = x * y;
        return total;

    }
    static void Main(string[] args)
    {
        double total;
        total = Math.Pow(4,3); // quatro ao cubo
        double raiz = Math.Sqrt(81); //raiz quadrada
        Console.WriteLine(total);
        Console.WriteLine(raiz);


        // funções de String

        string texto = "Este é o meu TEXTO original";
       string textoF = texto.ToUpper();
        Console.WriteLine(textoF);

        textoF = texto.ToLower();
        Console.WriteLine(textoF);

        //nossa função

        Program calculadora = new Program(); //instancia
        int num1 =8, num2 =6 , resultado;

        resultado = calculadora.multiplicar(num1,num2);
        Console.WriteLine(resultado);

        //calcular area do quadrado

        int lado = 10;

        int areaQuadrado = calculadora.multiplicar(lado, lado);
        Console.WriteLine("Area do quadrado: "+areaQuadrado);

    //area do triangulo
    int b = 8;
    int altura = 6;

    int areaTriangulo = calculadora.multiplicar(b,altura) / 2;
    Console.WriteLine("Area do triangulo: "+areaTriangulo);




    }
}
