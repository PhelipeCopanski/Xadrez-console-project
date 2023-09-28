using Tabuleiro;

namespace Xadrez_console_project
{
    class Program
    {
        static void Main(string[] args)
        {
            Posicao p = new Posicao { Linha = 3, Coluna = 4 };

            Console.WriteLine("Posição: " + p);
        }
    }
}