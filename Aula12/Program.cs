namespace Aula12;

public class Program
{
    public static void Main()
    {
        // Aula 12 - While
        // EXEMPLO 1:
        //int i = 0;

        //// a condição sempre vai estar em () e o bloco de código em {}.
        //while (i <= 8)
        //{
        //    Console.WriteLine(i);
        //    i++;
        //}

        double budget = 100;

        while (budget > 0)
        {
            Console.WriteLine($"Você possui {budget} na carteira.");
            // Realizando alguma operação
            budget -= 10;
        }
        Console.WriteLine("Atenção saldo insuficiente");
    }
}