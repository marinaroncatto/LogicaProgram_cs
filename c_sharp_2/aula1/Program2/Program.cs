namespace Program2;

class Program
{
    static void Main(string[] args)
    {
        //média de 3 notas

        //1 - coleta de dados

        Boletim boletim = new Boletim();
        Tela tela = new Tela();
        

        Console.WriteLine("--PROGRAMA DE MÉDIA --");
       boletim.Nota1 = tela.PedirNota("Informe a nota 01");
       boletim.Nota2 = tela.PedirNota("Informe a nota 02");
       boletim.Nota3 = tela.PedirNota("Informe a nota 03");

        //2 - Resolução do problema

        boletim.CalcularBoletim();
        
        //3 - apresentação do resultado

        tela.Exibir(boletim.Media, boletim.Situacao);

    }

}


