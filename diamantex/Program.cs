using System;

namespace diamantex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número ímpar: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            
            if (numero % 2 == 0)
            {
                Console.WriteLine("Número indisponível.");
                Console.ReadLine();
            }

            string espaco = " ";
            string xis = "X";

            int quantidadeespaco = (numero - 1) / 2;
            int quantidadex = 1;
            int quantidadelinhas = (numero -1) / 2;
            
            



            for (int linha = 0; linha < quantidadelinhas; linha++)
            {
                for(int i = 0; i < quantidadeespaco; i++)
                {
                    Console.Write(" ");
                }

                for( int i = 0;i < quantidadex; i++)
                {
                    Console.Write("X");
                }
                quantidadeespaco--;
                quantidadex += 2;

                Console.WriteLine();
            }

            for(int i = 0; i < numero; i++)
            {
                Console.Write("X");
            }
            quantidadeespaco++;
            quantidadex -= 2;
            Console.WriteLine();

            for (int linha = 0; linha < quantidadelinhas; linha++)
            {
                for (int i = 0; i < quantidadeespaco; i++)
                {
                    Console.Write(" ");
                }

                for (int i = 0; i < quantidadex; i++)
                {
                    Console.Write("X");
                }
                quantidadeespaco++;
                quantidadex -= 2;

                Console.WriteLine();
            }



            Console.ReadLine();
        }
    }
}
