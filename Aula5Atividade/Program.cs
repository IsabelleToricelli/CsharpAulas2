using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int altura = 10; // Altura da pirâmide
            int linhaAtual = 1; // Linha atual começando de 1

            while (linhaAtual <= altura)
            {
                // Imprime espaços para centralizar a pirâmide
                for (int espacos = 0; espacos < altura - linhaAtual; espacos++)
                {
                    Console.Write(" ");
                }
                // Imprime os caracteres da linha atual
                for (int chars = 0; chars < (2 * linhaAtual - 1); chars++)
                {
                    Console.Write("*");
                }
                // Move para a próxima linha
                Console.WriteLine();
                linhaAtual++;
            }
        }
    }
}
