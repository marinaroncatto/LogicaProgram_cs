namespace CampoMinado;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Campo Minado!");

        int[,] campo = new int[10, 10]; //matriz com posições dos elementos do campo
        int[,] jogo = new int[10, 10]; //matriz que registra ações do jogador

        int qtdLinhas = campo.GetLength(0); //armazena o tamanho do número d linhas
        int qtdColunas = campo.GetLength(1); //armazena o tamanho do número d colunas

        //Leitura de dados salvos
        bool problemaArquivo = false;
        string caminho_absoluto = "C:\\Users\\migue\\Documents\\Marina\\LogicaProgram_cs\\c_sharp_2\\apostila_matriz02\\campo.txt";
        string caminho_relativo = "..\\..\\..\\..\\campo.txt";

        try
        {
            //Informando o camimho e nome do arquivo;
            StreamReader sr = new StreamReader(caminho_absoluto);
            //leitura primeira linha
            String linha_arq = sr.ReadLine();
            int linha_mtz = 0;
            int coluna_mtz = 0;

            //ler até não ter nova linha
            while (linha_arq != null || linha_mtz < 10)
            {
                //separação de cada elemento da string pela vírgula
                foreach (var numero in linha_arq.Split(','))
                {
                    int num;
                    //conversão de cada elemento separado para um int
                    if (int.TryParse(numero, out num))
                    {
                        //armazena elemento na matriz campo
                        campo[linha_mtz, coluna_mtz] = num;
                        jogo[linha_mtz, coluna_mtz] = -1;
                        coluna_mtz++;
                    }
                }

                //leitura da próxima linha
                linha_arq = sr.ReadLine();
                //Avançando para a leitura da próxima linha,
                //começando pelo primeiro valor (primeira coluna)
                coluna_mtz = 0;
                linha_mtz++;
            }
            //encerramento da leitura do arquivo
            sr.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine("Ocorreu um problema na leitura do arquivo!");
            problemaArquivo = true;
        }

        /*  for (int l = 0; l < qtdLinhas; l++)
          {
              for (int c = 0; c < qtdColunas; c++)
              {
                  campo[l, c] = 0;
                  jogo[l, c] = -1;
              }
          }

          //posicionamento aleatório da bandeira
          Random gerador = new Random();
          int linha = gerador.Next(qtdLinhas);
          int coluna = gerador.Next(qtdColunas);
          campo[linha, coluna] = 2;

          //posicionamento aleatório das bombas
          int bombasPosicionadas = 0;

          do
          {
              linha = gerador.Next(qtdLinhas);
              coluna = gerador.Next(qtdColunas);
              if (campo[linha, coluna] == 0)
              {
                  campo[linha, coluna] = 1;
                  bombasPosicionadas++;
              }
          } while (bombasPosicionadas < 5); */

        //jogo
        if (!problemaArquivo)
        {
            bool fimJogo = false;
            bool vitoria = false;
            do
            {
                for (int l = 0; l < qtdLinhas; l++)
                {
                    for (int c = 0; c < qtdColunas; c++)
                    {
                        Console.Write(string.Format("{0} ", jogo[l, c]));
                    }
                    Console.Write(Environment.NewLine + Environment.NewLine);
                }
                Console.Write("Selecione uma linha [1-10]: ");
                int linha = Convert.ToInt32(Console.ReadLine()) - 1;
                Console.Write("Selecione uma coluna [1-10]: ");
                int coluna = Convert.ToInt32(Console.ReadLine()) - 1;

                switch (campo[linha, coluna])
                {
                    case 0:
                        jogo[linha, coluna] = 0;
                        Console.Write("Continue tentando. \n\n");
                        break;
                    case 1:
                        jogo[linha, coluna] = 1;
                        Console.Write("BOOOM. Você perdeu. \n\n");
                        fimJogo = true;
                        break;
                    default:
                        jogo[linha, coluna] = 2;
                        Console.Write("Parabéns. Você ganhou! \n\n");
                        fimJogo = true;
                        vitoria = true;
                        break;
                }

            } while (!fimJogo);

            //salvando dados da partida
            string[] arquivo = File.ReadAllLines(caminho_absoluto);
            string msgVitorias = arquivo[arquivo.Length - 2];
            string msgDerrotas = arquivo[arquivo.Length - 1];

            try
            {
                StreamWriter sw = new StreamWriter(caminho_absoluto);
                int contagem; //de vitórias ou derrotas
                int linha_sobrescrever;
                string texto;

                if (vitoria)
                {
                    int.TryParse(msgVitorias.Split(':')[1], out contagem);
                    linha_sobrescrever = 11;
                    texto = "Vitórias:";
                }
                else
                {
                    int.TryParse(msgDerrotas.Split(':')[1], out contagem);
                    linha_sobrescrever = 12;
                    texto = "Derrotas";
                }

                contagem++;

                for (int i = 0; i < arquivo.Length; i++)
                {
                    if (i == linha_sobrescrever)
                        sw.WriteLine(texto + contagem);
                    else
                        sw.WriteLine(arquivo[i]);
                }
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Ocorreu um problema na escrita do arquivo!");
            }

    } //fim if

    } //main
}
