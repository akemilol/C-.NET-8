namespace Aula07;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("========OPERADORES DE ATRIBUIÇÃO========");
        // Inicializar a variavel
        int a = 10; // (atribuição) = não é == (igualdade)
        Console.WriteLine($"Valor inicial da variavel de {a}");

        // Operador de atribuição Simples ( = )
        int x = 20;
        Console.WriteLine("\n Atribuição Simples ( = )");
        Console.WriteLine($"\n Valor de a = {x}");

        // Operador de atribuição composta incremento ( += )
        x++; // x = x + 1;
        Console.WriteLine($"\n Atribuição composta ( += ) {x}");

        // Operador de atribuição composta decremento ( -= )
        x--; // x = x - 1;
        Console.WriteLine($"\n Atribuição composta ( -= ) {x}");

        // Operador de atribuição composta multiplicação ( *= )
        x *= 2; // x = x * 2;
        Console.WriteLine($"\n Atribuição composta ( *= ) {x}");

        // Operador de atribuição composta divisão ( /= )
        x /= 2; // x = x / 2;
        Console.WriteLine($"\n Atribuição composta ( /= ) {x}");
    }
}