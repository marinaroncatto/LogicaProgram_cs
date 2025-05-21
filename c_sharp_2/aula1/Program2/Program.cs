namespace Program2;

class Program
{
    static void Main(string[] args)
    {
        //média de 3 notas

        //1 - coleta de dados

        Boletim boletim = new Boletim();

        Console.WriteLine("--PROGRAMA DE MÉDIA --");
       double n1 = boletim.PedirNota("Informe a nota 01");
       double n2 = boletim.PedirNota("Informe a nota 02");
       double n3 = boletim.PedirNota("Informe a nota 03");           

        //2 - Resolução do problema

        double media = boletim.CalcularMedia(n1,n2,n3);
        String situacao = boletim.VerificarSituacao(media);
        
        //3 - apresentação do resultado

        boletim.Exibir(media, situacao);

    }

}


