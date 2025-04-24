namespace Program1;

class Program
{
    static void Main(string[] args)
    {
        //média de 3 notas

        //1 - coleta de dados

        Console.WriteLine("--PROGRAMA DE MÉDIA --");
       double n1 = PedirNota("Informe a nota 01");
       double n2 = PedirNota("Informe a nota 02");
       double n3 = PedirNota("Informe a nota 03");           

        //2 - Resolução do problema

        double media = CalcularMedia(n1,n2,n3);
        String situacao = VerificarSituacao(media);
        
        //3 - apresentação do resultado

        Exibir(media, situacao);

    }

    public static double PedirNota(string msg){
        Console.WriteLine(msg);
        double nota =  Convert.ToDouble(Console.ReadLine());
        return nota;
    }

    public static double CalcularMedia(double n1, double n2, double n3){
        double media = (n1 + n2 + n3) / 3.0;
        return media;
    }

    public static string VerificarSituacao(double media){
       
       String situacao = " ";

        if(media >= 6){
            situacao = "Aprovado";
        }else{
            situacao = "Reprovado";
        }

        return situacao;
    }

    public static void Exibir(double media, string situacao){
        Console.WriteLine($"Media: {media}");
        Console.WriteLine($"Situação: {situacao}");
    }
}
