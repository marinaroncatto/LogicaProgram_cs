namespace JogoDaVelha;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Jogo da Velha!");

        char[,] tabuleiro = new char[3, 3];
        int linha;
        int coluna;
        bool fimJogo = false;
        int jogador = 1;
        int jogada = 0;

        //preenchimento da matriz com espaços em branco
        for (int l = 0; l < 3; l++)
        {
            for (int c = 0; c < 3; c++)
            {
                tabuleiro[l, c] = ' ';
            }
        }

        do
        {
            //impressão do tabuleiro atual
            imprimirTabuleiro(tabuleiro);

            if (jogador == 1)
                Console.Write("JODADOR 1: \n");
            else
                Console.Write("JODADOR 2: \n");

            Console.Write("Selecione uma linha [1-3]: ");
            linha = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.Write("Selecione uma coluna [1-3]: ");
            coluna = Convert.ToInt32(Console.ReadLine()) - 1;

            jogada++;

            //chada de função para verificar as consequências da jogada
            fimJogo = conferirJogada(tabuleiro, linha, coluna, jogador, jogada);

            //troca de jogador
            if (jogador == 1)
                jogador = 2;
            else
                jogador = 1;

        } while (!fimJogo);

    }// main

    static void imprimirTabuleiro(char[,] tabuleiro)
    {
        for (int l = 0; l < 3; l++)
        {
            for (int c = 0; c < 3; c++)
            {
                Console.Write(string.Format("{0}", tabuleiro[l, c]));
                if (c < 2)
                    Console.Write("|");
            }
            Console.Write(Environment.NewLine);
            if (l < 2)
                Console.Write("-----");
            Console.Write(Environment.NewLine);

        }
    }

    static bool conferirJogada(char[,] tabuleiro, int linha, int coluna, int jogador, int jogada)
    {
        bool trinca = false;

        if (jogador == 1)
            tabuleiro[linha, coluna] = 'X';
        else
            tabuleiro[linha, coluna] = 'O';

        //verificar na mesma linha
        for (int c = 0; c < 3; c++)
        {
            if (tabuleiro[linha, c] != tabuleiro[linha, coluna])
                break;
            if (c == 2)
                trinca = true;
        }

        //verificar na mesma coluna
        if (!trinca)
        {
            for (int l = 0; l < 3; l++)
            {
                if (tabuleiro[l, coluna] != tabuleiro[linha, coluna])
                    break;
                if (l == 2)
                    trinca = true;
            }
        }

        //verificar na diagonal principal
        if (!trinca)
        {
            if (linha == coluna)
            {
                for (int cont = 0; cont < 3; cont++)
                {
                    if (tabuleiro[cont, cont] != tabuleiro[linha,
                    coluna])
                        break;
                    if (cont == 2)
                        trinca = true;
                }
            }
        }

        //Verificar diagonal secundária
        if (!trinca)
        {
            if (linha + coluna == 3 - 1)
            {
                for (int cont = 0; cont < 3; cont++)
                {
                    if (tabuleiro[cont, 3 - cont - 1] != tabuleiro[linha, coluna])
                        break;
                    if (cont == 2)
                        trinca = true;

                }
            }
        }

        if (trinca)
        {
            Console.WriteLine();
            imprimirTabuleiro(tabuleiro);
            Console.Write("JOGADOR " + jogador + " VENCEU!\n\n");
            return true;
        }

        if (jogada == 9)
        {
            Console.WriteLine();
            imprimirTabuleiro(tabuleiro);
            Console.Write("EMPATE!\n\n");
            return true;
        }
        else
        {
            Console.Write("\nPRÓXIMO JOGADOR...\n\n");
            return false;
        }
        
    }





} //class
