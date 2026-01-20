using System;
namespace JogoAdivinhacao
{
    class Program
    {
        static void Main(string[] args) 
        {
            Random gerador = new Random();
            int numeroSecreto = gerador.Next(1,101);
            int palpite = 0;
            bool acertou = false;

            Console.WriteLine("========================================");
            Console.WriteLine("  Bem-vindo ao Jogo da Adivinhação!   ");
            Console.WriteLine("  Tente adivinhar o número de 1 a 100.  ");
            Console.WriteLine("========================================");

            while (acertou == false)
            {
                Console.Write("Digite seu palpite: ");
                string entradaUsuario = Console.ReadLine();

                palpite = int.Parse(entradaUsuario); //transforma texto em número
                if (palpite == numeroSecreto)
                {
                    Console.WriteLine("PARABÉNS, VOCÊ ACERTOU!");
                    acertou = true;
                }
                else if (palpite <  numeroSecreto)
                {
                    Console.WriteLine("o número é maior que" + palpite);
                }
                else if ((palpite > numeroSecreto)
                    {
                    Console.WriteLine("o número é menor que" + palpite);
                }
                Console.WriteLine("Fim do jogo. Pressione qualquer tecla para sair")
                    Console.ReadKey();
            }
        }
}