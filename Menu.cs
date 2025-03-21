using System;
using System.Threading;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("🎵 Escolha uma música para ver a letra: ");
            Console.WriteLine("1 - Solo - Frank Ocean");
            Console.WriteLine("2 - Chop Suey! - System Of A Down");
            Console.WriteLine("3 - Sair");
            Console.Write("Digite o número da música: ");

            string? escolha = Console.ReadLine();

            switch (escolha)
            {
                case "1":
                    Letras.DisplaySolo();
                    break;
                case "2":
                    Letras.DisplayChopSuey();
                    break;
                case "3":
                    Console.WriteLine("Saindo...");
                    return;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    Thread.Sleep(1000);
                    break;
            }
        }
    }
}