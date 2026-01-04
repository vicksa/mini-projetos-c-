using System;

public class SimuladorDados
{
    private static void Main(string[] args)
    {
        Console.WriteLine("===== Simulador de Dados =====");
        Console.WriteLine("Pressione Enter para rolar o dado");
        Console.ReadKey();

        Random gerador = new Random();

        
        int resultado = gerador.Next(1, 7);
        
        Console.WriteLine($"\nO dado foi rolado...");
        Console.WriteLine($"O resultado é: {resultado}");

        Console.WriteLine("\nPressione Enter para sair");
        Console.ReadKey();
    }
}
