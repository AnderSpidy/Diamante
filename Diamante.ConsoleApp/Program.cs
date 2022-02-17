using System;

namespace Diamante.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Entrar com o valor do Usuario
            int linhaDiamante = 0;
            Console.ForegroundColor = ConsoleColor.Cyan;
            while (linhaDiamante % 2 == 0) //so vai manter o while se o o numero de linha do Diamante divido por dois, o resto da divição der igual a zero, pois caso contrario, este numero seria ímpar
            {
                Console.WriteLine("Digite um numero ímpar?");
                linhaDiamante = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }
            #endregion
            #region a primeira metade do diamante
            int metadeDiamante = (linhaDiamante - 1) / 2; // Divide o diamante em duas partes, para mudar a diagonal da metade pra baixo
            {
                for (int i = 0; i < metadeDiamante; ++i) // O laço para desenhar a primeira metade do diamante
                {
                    for (int j = 0; j < metadeDiamante - i; j++) 
                    {
                        Console.Write(" ");
                    }
                    int contador = (2 * i) + 1;
                    for (int j = 0; j < contador; j++)
                    {
                        Console.Write("X");
                    }
                    Console.WriteLine();
                }
                #endregion
            #region A segunda metade do diamante
                for (int i = metadeDiamante; i >= 0 ; i--)
                {
                    for (int j = 0; j < metadeDiamante - i; j++)
                    {
                        Console.Write(" ");
                    }
                    int contador = (2 * i) + 1;
                    for (int j = 0; j < contador; j++)
                    {
                        Console.Write("X");
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadLine();
            #endregion
        }
    }
}
