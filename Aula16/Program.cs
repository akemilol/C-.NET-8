namespace Aula16;

public class Program
{
    public static void Main()
    {

        var separator = "----------------------";

        // Array
        // 1. Declaração de Array inicializado com valores
        string[] fruits = { "Morango", "Uva", "Goiaba", "Abacate"};

        // 2. Acessando valores do elementos array
        Console.WriteLine(fruits[0]); // Morango

        Console.WriteLine(separator);

        foreach (string fruit in fruits)
        {
            Console.WriteLine($"Usando o foreach: {fruit}");
        }

        Console.WriteLine(separator);

        //3. Contagem de índices
        Console.WriteLine($"Quantidade de índices: {fruits.Length}"); // 4

        Console.WriteLine(separator);

        //4. Alterar os valores
        Console.WriteLine($"Valor antes da alteração: {fruits[1]}");
        fruits[1] = "Abacate";
        Console.WriteLine($"Valor depois da alteração: {fruits[1]}");

        Console.WriteLine(separator);

        //5. Declararação de array sem inicializar
        // Quando nao declaramos os valores precisamos declarar a quantidade [3]
        int[] numbers = new int[3];

        // atribuindo valor
        numbers[0] = 10;
        numbers[1] = 20;
        numbers[2] = 30;
        // numbers[3] = 40; // Erro de compilação

        foreach (int number in numbers)
        {
            Console.WriteLine($"Usando o foreach: {number}");
        }
    }
}