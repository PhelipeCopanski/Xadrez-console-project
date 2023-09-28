using tabuleiro;
using xadrez;

namespace Xadrez_console_project
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao {Linha = 0, Coluna = 0 });
            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao { Linha = 1, Coluna = 3 });
            tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao { Linha = 2, Coluna = 4 });

            Tela.ImprimirTabuleiro(tab);
        }
    }
}